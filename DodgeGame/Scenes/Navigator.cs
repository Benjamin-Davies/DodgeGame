using System;
using System.Collections.Generic;
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
        private readonly Stack<IScene> Scenes;

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
        /// Add the current scene to the window
        /// </summary>
        protected void Attach()
        {
            if (StackDepth > 0)
            {
                var nextScene = CurrentScene;
                Form.Controls.Add((Control)nextScene);
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
