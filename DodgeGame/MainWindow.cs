using DodgeGame.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
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

        // Polymorphic instance of scene
        private IScene scene;

        public MainWindow()
        {
            // Built in method to construct UI from designer
            InitializeComponent();
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

            // Create a config prompt
            var configPrompt = new ConfigPrompt();

            // Show the config prompt
            configPrompt.ShowDialog(this);

            // Create our scene instance
            scene = new DodgeScene(this, configPrompt.Username.Text, (int)configPrompt.LifeCount.Value);
            scene.Resume();
            Controls.Add((Control)scene);

            FrameTimer.Enabled = true;
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            scene.Pause();
        }

        private void FrameTimer_Tick(object sender, EventArgs e)
        {
            scene.UpdateScene();

            // Tell the window to redraw
            Invalidate();
        }
    }
}