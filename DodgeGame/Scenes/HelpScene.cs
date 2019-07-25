using DodgeGame.Properties;
using System;
using System.Windows.Forms;

namespace DodgeGame.Scenes
{
    /// <summary>
    /// Scene that contains a description of how to play the game
    /// </summary>
    public partial class HelpScene : UserControl, IScene
    {
        private MainWindow form;
        private Navigator navigator;

        public HelpScene(MainWindow _form, Navigator _navigator)
        {
            InitializeComponent();

            HelpText.Text = Resources.Instructions;

            BackButton.BackColor = Resources.AltBackColor;

            form = _form;
            navigator = _navigator;
        }

        // Unused interface methods
        public void Pause() { } 
        public void Resume() { } 
        public void UpdateScene() { }

        /// <summary>
        /// Is called when the HelpScene is created
        /// </summary>
        private void HelpScene_Load(object sender, EventArgs e)
        {
            // Fill the window
            Dock = DockStyle.Fill;
        }

        /// <summary>
        /// Exit the scene
        /// </summary>
        private void BackButton_Click(object sender, EventArgs e)
        {
            // Go back
            navigator.Pop();
        }
    }
}
