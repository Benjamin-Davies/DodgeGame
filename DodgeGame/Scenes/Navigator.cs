using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DodgeGame.Scenes
{
    /// <summary>
    /// Class that handles swapping out scenes
    ///
    /// The scenes are stored on a stack to mimic
    /// the navigation found on most mobile platforms,
    /// as this is most likely familiar to the player
    /// </summary>
    public class Navigator
    {
        private readonly Form Form;
        private Stack<IScene> Scenes;
        private Stack<IScene> ChangedScenes;
        private bool Delayed;

        public IScene CurrentScene => Scenes.Count > 0 ? Scenes.Peek() : null;
        public int StackDepth => Scenes.Count;

        public Navigator(Form form)
        {
            Form = form;
            Scenes = new Stack<IScene>();
        }

        /// <summary>
        /// Use a new scene, placing it ontop of existing scenes
        /// </summary>
        public void Push(IScene nextScene)
        {
            // Pause the last scene, if there was one
            Dettach();

            // Push our new scene to the stack
            Scenes.Push(nextScene);

            // Use the new scene
            Attach();
        }

        /// <summary>
        /// Use the last scene, and discard the current one
        /// </summary>
        public void Pop()
        {
            // Stop using the last scene
            Dettach();

            if (Delayed)
            {
                // Set up the next state, but don't execute it yet
                // Passing a stack to the constructor flips the order, so we need to reverse it
                var reversed = new Stack<IScene>(Scenes);
                ChangedScenes = new Stack<IScene>(reversed);

                // Pop the last scene from the stack
                ChangedScenes.Pop();

                // Don't do anything else
                return;
            }

            // Pop the last scene from the stack
            Scenes.Pop();

            // Use the next scene
            Attach();
        }

        /// <summary>
        /// Use a new scene, replacing the current scene
        /// </summary>
        public void Replace(IScene scene)
        {
            // Stop using the last scene
            Dettach();

            // Swap out the current scene
            Scenes.Pop();
            Scenes.Push(scene);

            // Use the next scene
            Attach();
        }

        /// <summary>
        /// Delay the current navigation until the callback has finished
        /// Cancels the operation if the callback returns false
        /// Currently only works to stop "Pops"
        /// </summary>
        public void DelayNavigation(Func<Task<bool>> func)
        {
            // Set the flag to tell Pop to pause
            Delayed = true;

            // Run the method asynchonously
            Task.Run(async () => {
                // Run the callback
                bool continiue = await func();

                // Only use the new state if we are told to continiue
                if (continiue)
                {
                    Scenes = ChangedScenes;
                }

                // Re-attach the scene
                // Must run on the UI thread
                Form.Invoke((MethodInvoker)delegate {
                    Attach();
                });
            });
        }

        /// <summary>
        /// Add the current scene to the window
        /// </summary>
        protected void Attach()
        {
            if (StackDepth > 0)
            {
                var nextScene = CurrentScene;
                Form.Controls.Add((Control)nextScene);
                Form.ActiveControl = (Control)nextScene;
                nextScene.Resume();
            }
        }

        /// <summary>
        /// Remove the current scene from the window
        /// </summary>
        protected void Dettach()
        {
            if (StackDepth > 0)
            {
                var lastScene = CurrentScene;
                lastScene.Pause();
                Form.Controls.Remove((Control)lastScene);
            }
        }
    }
}
