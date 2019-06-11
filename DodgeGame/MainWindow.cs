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
        // Member variables for storing the state of the game
        private string username;
        private int score;
        private int livesLeft;
        private List<Planet> planets;
        private Spaceship spaceship;

        public MainWindow()
        {
            // Built in method to construct UI from designer
            InitializeComponent();

            // Init variables
            username = "";
            score = 0;
            livesLeft = 0;

            // Create some dummy planets
            planets = new List<Planet>();
            for (int i = 0; i < 8; i++)
            {
                planets.Add(new Planet(new Point(100 * i, 0)));
            }

            // Create a spaceship
            spaceship = new Spaceship(new Point(0, 100));
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            // Create a config prompt
            var configPrompt = new ConfigPrompt();

            // Show the config prompt until the user presses Ok
            while (configPrompt.ShowDialog(this) != DialogResult.OK) ;

            // Store the inputs from the config prompt
            username = configPrompt.Username.Text;
            livesLeft = (int)configPrompt.LifeCount.Value;

            // Only start moving stuff once we show the window
            FrameTimer.Enabled = true;
        }

        private void MainWindow_Paint(object sender, PaintEventArgs e)
        {
            // Get the drawing context
            var g = e.Graphics;

            // Clear the screen
            g.FillRectangle(Brushes.DarkSlateBlue, e.ClipRectangle);

            // Loop through all of the planets and draw them
            foreach (var planet in planets)
            {
                planet.Draw(g);
            }

            // Draw the spaceship
            spaceship.Draw(g);

            // Draw the text
            g.DrawString($"Score: {score}", Font, Brushes.White, 5, 5);
            g.DrawString($"Lives: {livesLeft}", Font, Brushes.White, 5, 15 + Font.Size);
        }

        private void FrameTimer_Tick(object sender, EventArgs e)
        {
            // Loop through the planets and update them
            foreach (var planet in planets)
            {
                planet.Update();
            }

            // Tell the window to redraw
            Invalidate();
        }
    }
}