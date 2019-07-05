using System.Collections.Generic;
using System.Windows.Forms;

namespace DodgeGame
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
            if (StackDepth > 0)
            {
                var lastScene = CurrentScene;
                lastScene.Pause();
                Form.Controls.Remove((Control)lastScene);
            }

            // Push our new scene to the stack
            Scenes.Push(nextScene);
            Form.Controls.Add((Control)nextScene);
            nextScene.Resume();
        }

        public void Pop()
        {
            // Pop the last scene from the stack
            var lastScene = Scenes.Pop();
            lastScene.Pause();
            Form.Controls.Remove((Control)lastScene);

            // Use the next scene
            if (StackDepth > 0)
            {
                var nextScene = CurrentScene;
                Form.Controls.Add((Control)nextScene);
                nextScene.Resume();
            }
        }
    }
}
