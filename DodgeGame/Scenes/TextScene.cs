using System;
using System.Windows.Forms;

namespace DodgeGame.Scenes
{
    public partial class TextScene : UserControl, IScene
    {
        private MainWindow form;
        private Navigator navigator;

        public TextScene(MainWindow _form, Navigator _navigator, string text)
        {
            InitializeComponent();
            titleLabel.Text = text;

            form = _form;
            navigator = _navigator;
        }

        public void Pause() { } 
        public void Resume() { } 
        public void UpdateScene() { }

        private void TextScene_Load(object sender, EventArgs e)
        {
            // Fill the window
            Dock = DockStyle.Fill;
        }

        private void TextScene_MouseUp(object sender, MouseEventArgs e)
        {
            // Exit the scene
            navigator.Pop();
        }
    }
}
