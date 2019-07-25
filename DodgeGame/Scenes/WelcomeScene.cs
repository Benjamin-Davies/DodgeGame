﻿using DodgeGame.Properties;
using System;
using System.Windows.Forms;

namespace DodgeGame.Scenes
{
    /// <summary>
    /// Scene that shows when the game is launched
    /// Contains buttons to navigate to different parts of the application
    /// </summary>
    public partial class WelcomeScene : UserControl, IScene
    {
        private MainWindow form;
        private Navigator navigator;

        public WelcomeScene(MainWindow _form, Navigator _navigator)
        {
            // Set up the controll (code generated by designer)
            InitializeComponent();

            PlayButton.BackColor = Resources.AltBackColor;
            HelpButton.BackColor = Resources.AltBackColor;
            SettingsButton.BackColor = Resources.AltBackColor;
            QuitButton.BackColor = Resources.AltBackColor;

            // Init variables
            form = _form;
            navigator = _navigator;
        }

        // Unused interface method
        public void Pause() { }
        public void Resume() { }
        public void UpdateScene() { }

        /// <summary>
        /// Called when the scene loads
        /// </summary>
        private void WelcomeScene_Load(object sender, EventArgs e)
        {
            // Fill the window
            Dock = DockStyle.Fill;
        }

        /// <summary>
        /// Called when the play button is clicked
        /// </summary>
        private void PlayButton_Click(object sender, EventArgs e)
        {
            // Go to the DodgeScene
            navigator.Push(new DodgeScene(form, navigator));
        }

        /// <summary>
        /// Called when the settings button is clicked
        /// </summary>
        private void SettingsButton_Click(object sender, EventArgs e)
        {
            // Go to the settings scene
            navigator.Push(new SettingsScene(form, navigator));
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
            // Quit the game
            form.Close();
        }
    }
}
