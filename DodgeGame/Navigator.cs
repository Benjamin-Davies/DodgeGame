using System.Collections.Generic;
using System.Windows.Forms;

namespace DodgeGame
{
    public class Navigator
    {
        private readonly Form Form;
        private readonly Stack<IScene> Scenes;

        public IScene CurrentScene => Scenes.Peek();

        public Navigator(Form form)
        {
            Form = form;
            Scenes = new Stack<IScene>();
        }

        public void Push(IScene nextScene)
        {
            // Pause the last scene, if there was one
            var lastScene = CurrentScene;
            if (lastScene != null)
            {
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
            var nextScene = CurrentScene;
            if (nextScene != null)
            {
                Form.Controls.Add((Control)nextScene);
                nextScene.Resume();
            }
        }
    }
}
