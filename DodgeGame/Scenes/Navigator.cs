using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DodgeGame.Scenes
{
    public class Navigator
    {
        private readonly Form Form;
        private readonly Stack<IScene> Scenes;

        public IScene CurrentScene => Scenes.Peek();
        public int StackDepth => Scenes.Count;

        public Navigator(Form form)
        {
            Form = form;
            Scenes = new Stack<IScene>();
        }

        public void Push(IScene nextScene)
        {
            // Pause the last scene, if there was one
            Dettach();

            // Push our new scene to the stack
            Scenes.Push(nextScene);

            // Use the new scene
            Attach();
        }

        public void Pop()
        {
            // Stop using the last scene
            Dettach();

            // Pop the last scene from the stack
            Scenes.Pop();

            // Use the next scene
            Attach();
        }

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

        protected void Attach()
        {
            if (StackDepth > 0)
            {
                var nextScene = CurrentScene;
                Form.Controls.Add((Control)nextScene);
                nextScene.Resume();
            }
        }

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
