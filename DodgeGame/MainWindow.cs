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
        // Constant values
        private const int planetHeight = 77;
        private const int starHeight = 10;

        // Member variables for storing the state of the game
        private string username;
        private int score;
        private int livesLeft;
        private List<BackgroundStar> stars;
        private List<Planet> planets;
        private Spaceship spaceship;
        private Random random;
        private bool mouseOverWindow = true;
        private bool instructionsShown = false;

        public MainWindow()
        {
            // Built in method to construct UI from designer
            InitializeComponent();

            // Init variables
            username = "";
            score = 0;
            livesLeft = 0;

            // Create a list of stars and a list of planets
            stars = new List<BackgroundStar>();
            planets = new List<Planet>();

            // Create a spaceship
            spaceship = new Spaceship();

            // Initialize a random number generator
            random = new Random();
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

            // Store the inputs from the config prompt
            username = configPrompt.Username.Text;
            livesLeft = (int)configPrompt.LifeCount.Value;

            // Reset the score
            score = 0;

            // Only start moving stuff once we show the window
            FrameTimer.Enabled = true;
            PlanetTimer.Enabled = true;
            StarTimer.Enabled = true;
        }

        private void MainWindow_Paint(object sender, PaintEventArgs e)
        {
            // Get the drawing context
            var g = e.Graphics;

            // Clear the screen
            g.FillRectangle(Brushes.Indigo, e.ClipRectangle);
             
            // If the mouse isn't over the window, show some text
            if (!mouseOverWindow)
            {
                var font = new Font(Font.FontFamily, 72);
                var format = new StringFormat
                {
                    Alignment = StringAlignment.Center,
                    LineAlignment = StringAlignment.Center
                };
                g.DrawString(
                    "Move The Mouse\nTo Over\nThe Window",
                    font,
                    Brushes.SkyBlue,
                    new PointF(e.ClipRectangle.Width / 2f, e.ClipRectangle.Height / 2f),
                    format);
            }

            // Loop through all of the stars and draw them
            foreach (var star in stars)
            {
                star.Draw(g);
            }

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
            // Increment the score
            score++;

            // Remove the planets that have fallen off of the screen
            // We use a reverse for loop so that, when we remove planets, we dont skip any
            for (int i = planets.Count - 1; i >= 0; i--)
            {
                if (planets[i].Position.Y > ClientSize.Height)
                    planets.RemoveAt(i);
            }

            // Speed up the planets with the score
            Planet.Speed = 10 + score / 500f;

            // Loop through the stars and update them
            foreach (var star in stars)
            {
                star.Update(ClientSize);
            }

            // Loop through the planets and update them
            foreach (var planet in planets)
            {
                planet.Update(ClientSize);
            }

            // Update our spaceship
            spaceship.Update(ClientSize);

            // Check for collisions
            if (CheckCollisions())
            {
                // Remove all of the planets and decrement lifeCount
                planets.Clear();
                livesLeft--;

                // Disable updates while we prompt the user
                FrameTimer.Enabled = false;
                PlanetTimer.Enabled = false;
                StarTimer.Enabled = false;

                // Check if we are out of lives
                if (livesLeft <= 0)
                {
                    // Tell the user he/she is out of lives
                    MessageBox.Show(this, $"{username} finished with {score} points.", "Game Over");

                    // Reset the game by running the init method
                    MainWindow_Load(this, new EventArgs());
                }
                else
                {
                    // Tell the user he/she died
                    MessageBox.Show(this, "You have been hit by a planet", "You died");
                }

                // Enable the timers again
                FrameTimer.Enabled = true;
                PlanetTimer.Enabled = true;
                StarTimer.Enabled = true;
            }

            // Tell the window to redraw
            Invalidate();
        }

        private bool CheckCollisions()
        {
            // Loop through all of the planets
            foreach (var planet in planets)
            {
                // And check if the intersect with our spaceship
                if (planet.CollidesWith(spaceship.Rectangle))
                    return true;
            }
            return false;
        }

        private void MainWindow_MouseMove(object sender, MouseEventArgs e)
        {
            // Move the spaceship to in line with the mouse
            spaceship.Position.X = e.X - spaceship.Size.Width / 2;
        }

        private void PlanetTimer_Tick(object sender, EventArgs e)
        {
            // Choose a random position for the new planet
            var xPosition = random.Next(0, Width - planetHeight);

            // Create a new planet and add it to the planets list
            var planet = new Planet(new PointF(xPosition, -planetHeight));
            planets.Add(planet);
        }

        private void StarTimer_Tick(object sender, EventArgs e)
        {
            // Choose a random position and speed for the new star
            var xPosition = random.Next(0, Width - planetHeight);
            var speed = 0.25 + 0.5 * random.NextDouble();

            // Create a new star and add it to the stars list
            var star = new BackgroundStar(new PointF(xPosition, -starHeight), (float)speed);
            stars.Add(star);
        }

        private void MainWindow_MouseEnter(object sender, EventArgs e)
        {
            mouseOverWindow = true;
        }

        private void MainWindow_MouseLeave(object sender, EventArgs e)
        {
            mouseOverWindow = false;
        }
    }
}
