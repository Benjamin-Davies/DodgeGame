using DodgeGame.Properties;
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
            BackgroundImage = Resources.background;
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

        /// <summary>
        /// Called when the user releases a key
        /// </summary>
        private void MainWindow_KeyUp(object sender, KeyEventArgs e)
        {
            // Do different things depending on what keys and modifiers were pressed
            switch (e.KeyData)
            {
                case Keys.Escape:
                    // When escape is pressed, check what scene we are on
                    if (navigator.CurrentScene is WelcomeScene)
                    {
                        // If the game is on the welcome screen, then prompt the user to close.
                        if (MessageBox.Show(this, "Are you sure that you want to quit?", "", MessageBoxButtons.YesNo)
                            == DialogResult.Yes)
                            Close();
                    }
                    else if (navigator.CurrentScene is DodgeScene)
                    {
                        // If the game is running, pause the game
                        navigator.Push(new PauseScene(this, navigator));
                    }
                    else
                    {
                        // Leave the current scene
                        navigator.Pop();
                    }
                    break;
                case Keys.F1:
                    // When F1 is pressed, show the help message
                    navigator.Push(new HelpScene(this, navigator));
                    break;
            }
        }
    }
}
