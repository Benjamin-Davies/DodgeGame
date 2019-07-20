using System.Windows.Forms;

namespace DodgeGame.Scenes
{
    /// <summary>
    /// Interface implemented by all scenes
    ///
    /// IContainerControl is used to ensure that only Containers
    /// can implement this interface
    /// </summary>
    public interface IScene : IContainerControl
    {
        /// <summary>
        /// Update the scene
        /// </summary>
        void UpdateScene();

        /// <summary>
        /// Is called whenever the scene is temporarily hidden
        /// </summary>
        void Pause();
        /// <summary>
        /// Is called whenever the scene is shown
        /// </summary>
        void Resume();
    }
}
