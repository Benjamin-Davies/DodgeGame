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
        private Scene scene;

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
            scene.Start();

            FrameTimer.Enabled = true;
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            scene.Stop();
        }

        private void MainWindow_Paint(object sender, PaintEventArgs e)
        {
            scene.Paint(e);
        }

        private void FrameTimer_Tick(object sender, EventArgs e)
        {
            scene.Update();

            // Tell the window to redraw
            Invalidate();
        }

        private void MainWindow_MouseMove(object sender, MouseEventArgs e)
        {
            scene.MouseMove(e);
        }

        private void MainWindow_MouseEnter(object sender, EventArgs e)
        {
            scene.MouseEnter();
        }

        private void MainWindow_MouseLeave(object sender, EventArgs e)
        {
            scene.MouseLeave();
        }
    }
}