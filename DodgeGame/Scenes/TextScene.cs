using System;
using System.Windows.Forms;

namespace DodgeGame.Scenes
{
    /// <summary>
    /// Scene for displaying text
    /// </summary>
    public partial class TextScene : UserControl, IScene
    {
        private MainWindow form;
        private Navigator navigator;

        public TextScene(MainWindow _form, Navigator _navigator, string text)
        {
            InitializeComponent();

            // Set the text to what has been provided
            titleLabel.Text = text;

            form = _form;
            navigator = _navigator;
        }

        // Unused interface methods
        public void Pause() { } 
        public void Resume() { } 
        public void UpdateScene() { }

        /// <summary>
        /// Is called when the scene is created
        /// </summary>
        private void TextScene_Load(object sender, EventArgs e)
        {
            // Fill the window
            Dock = DockStyle.Fill;
        }

        /// <summary>
        /// Exit the scene when the mouse is pressed
        /// </summary>
        private void TextScene_MouseUp(object sender, MouseEventArgs e)
        {
            // Exit the scene
            navigator.Pop();
        }
    }
}
