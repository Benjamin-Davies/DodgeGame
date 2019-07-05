using System.Windows.Forms;

namespace DodgeGame.Scenes
{
    public interface IScene : IContainerControl
    {
        void UpdateScene();

        void Pause();
        void Resume();
    }
}
