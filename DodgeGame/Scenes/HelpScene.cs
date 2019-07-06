using DodgeGame.Properties;
using System;
using System.Windows.Forms;

namespace DodgeGame.Scenes
{
    public partial class HelpScene : UserControl, IScene
    {
        private MainWindow form;
        private Navigator navigator;

        public HelpScene(MainWindow _form, Navigator _navigator)
        {
            InitializeComponent();

            HelpText.Text = Resources.Instructions;

            form = _form;
            navigator = _navigator;
        }

        public void Pause() { } 
        public void Resume() { } 
        public void UpdateScene() { }

        private void HelpScene_Load(object sender, EventArgs e)
        {
            // Fill the window
            Dock = DockStyle.Fill;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            // Go back
            navigator.Pop();
        }
    }
}
