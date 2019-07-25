using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DodgeGame.Properties;

namespace DodgeGame.Scenes
{
    public partial class PauseScene : UserControl, IScene
    {
        private MainWindow form;
        private Navigator navigator;

        public PauseScene(MainWindow _form, Navigator _navigator)
        {
            InitializeComponent();

            ResumeButton.BackColor = Resources.AltBackColor;
            HelpButton.BackColor = Resources.AltBackColor;
            QuitButton.BackColor = Resources.AltBackColor;

            form = _form;
            navigator = _navigator;
        }

        // Unused interface methods
        public void Pause() { }
        public void Resume() { }
        public void UpdateScene() { }

        /// <summary>
        /// Called when the control is created
        /// </summary>
        private void PauseScene_Load(object sender, EventArgs e)
        {
            Dock = DockStyle.Fill;
        }

        /// <summary>
        /// Called when the resume button is clicked
        /// </summary>
        private void ResumeButton_Click(object sender, EventArgs e)
        {
            // Exit the scene
            navigator.Pop();
        }

        /// <summary>
        /// Called when the help button is clicked
        /// </summary>
        private void HelpButton_Click(object sender, EventArgs e)
        {
            // Go to the help scene
            navigator.Push(new HelpScene(form, navigator));
        }

        /// <summary>
        /// Called when the quit button is clicked
        /// </summary>
        private void QuitButton_Click(object sender, EventArgs e)
        {
            // Exit the scene
            navigator.Pop();

            // If we are in a DodgeScene, the exit that aswell
            if (navigator.CurrentScene is DodgeScene)
                navigator.Pop();
        }
    }
}
