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
        // So that we only show the instructions once
        private bool instructionsShown = false;

        // Store the navigator instance
        private Navigator navigator;

        // If the mouse is currently over the window
        public bool MouseOverWindow = true;

        public MainWindow()
        {
            // Built in method to construct UI from designer
            InitializeComponent();

            // Set the colours from resources
            BackColor = Resources.BackColor;
            ForeColor = Resources.ForeColor;
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            // Only show the instructions once
            if (!instructionsShown)
            {
                // Show the instructions
                MessageBox.Show(this, Resources.Instructions, "Instructions");

                // Dont show them again
                instructionsShown = true;
            }

            // Create a navigator
            navigator = new Navigator(this);

            // Create our scene instance
            var scene = new WelcomeScene(this, navigator);
            navigator.Push(scene);

            // Start updating the game
            FrameTimer.Enabled = true;
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            navigator.CurrentScene.Pause();
        }

        private void FrameTimer_Tick(object sender, EventArgs e)
        {
            navigator.CurrentScene.UpdateScene();
        }

        public void MainWindow_MouseEnter(object sender, EventArgs e)
        {
            MouseOverWindow = true;
        }

        public void MainWindow_MouseLeave(object sender, EventArgs e)
        {
            MouseOverWindow = false;
        }
    }
}
