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
        /// Is called when the form closes
        /// </summary>
        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            navigator.CurrentScene.Pause();
        }

        /// <summary>
        /// Is called every frame
        /// </summary>
        private void FrameTimer_Tick(object sender, EventArgs e)
        {
            navigator.CurrentScene.UpdateScene();
        }

        /// <summary>
        /// Is called when the mouse enters the window
        /// </summary>
        public void MainWindow_MouseEnter(object sender, EventArgs e)
        {
            MouseOverWindow = true;
        }

        /// <summary>
        /// Is called when the mouse leaves the window
        /// </summary>
        public void MainWindow_MouseLeave(object sender, EventArgs e)
        {
            MouseOverWindow = false;
        }
    }
}
