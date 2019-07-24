﻿using DodgeGame.Properties;
using DodgeGame.Scenes;
using System;
using System.Windows.Forms;

namespace DodgeGame
{
    /// <summary>
    /// The main window that the game is played in
    /// </summary>
    public partial class MainWindow : Form
    {
        // Store the navigator instance
        private Navigator navigator;

        public MainWindow()
        {
            // Built in method to construct UI from designer
            InitializeComponent();

            // Set the colours from resources
            BackColor = Resources.BackColor;
            ForeColor = Resources.ForeColor;
        }

        /// <summary>
        /// Is called when the window is created
        /// </summary>
        private void MainWindow_Load(object sender, EventArgs e)
        {
            // Create a navigator
            navigator = new Navigator(this);

            // Create our scene instance
            var scene = new WelcomeScene(this, navigator);
            navigator.Push(scene);

            // Start updating the game
            FrameTimer.Enabled = true;
        }

        /// <summary>
        /// Is called every frame
        /// </summary>
        private void FrameTimer_Tick(object sender, EventArgs e)
        {
            navigator.CurrentScene.UpdateScene();
        }

        private void MainWindow_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.Escape:
                    if (navigator.CurrentScene is DodgeScene)
                    {
                        navigator.Push(new PauseScene(this, navigator));
                    }
                    else
                    {
                        navigator.Pop();
                    }
                    break;
            }
        }
    }
}
