using System.ComponentModel;
using System.Windows.Forms;

namespace DodgeGame
{
    public interface IScene : IContainerControl
    {
        void UpdateScene();

        void Pause();
        void Resume();
    }
}
