using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace DodgeGame
{
    class DodgeScene : Scene
    {
        // Constant values
        private const int planetHeight = 77;
        private const int starHeight = 10;

        // Member variables for storing the state of the game
        private readonly string username;
        private int score;
        private int lifeCount;
        private int livesLeft;
        private List<BackgroundStar> stars;
        private List<Planet> planets;
        private Spaceship spaceship;
        private Random random;
        private bool mouseOverWindow = true;
        private Form form;

        // Timers
        private Timer PlanetTimer;
        private Timer StarTimer;

        public DodgeScene(Form _form, string _username, int _lifeCount)
        {

            // Init variables
            form = _form;
            username = _username;
            lifeCount = _lifeCount;

            // Initialize a random number generator
            random = new Random();
        }

        public override void Start()
        {
            base.Start();

            // Reset the score and life count
            score = 0;
            livesLeft = lifeCount;

            // Create a list of stars and a list of planets
            stars = new List<BackgroundStar>();
            planets = new List<Planet>();

            // Create a spaceship
            spaceship = new Spaceship();

            // Initialize the timers
            PlanetTimer = new Timer
            {
                Interval = 200
            };
            PlanetTimer.Tick += PlanetTimer_Tick;
            // Add it to our components container so that it can get automatically cleaned up
            components.Add(PlanetTimer);
            StarTimer = new Timer
            {
                Interval = 100
            };
            StarTimer.Tick += StarTimer_Tick;
            components.Add(StarTimer);

            // Only start moving stuff once we show the window
            PlanetTimer.Enabled = true;
            StarTimer.Enabled = true;
        }

        public override void Paint(PaintEventArgs e)
        {
            var g = e.Graphics;

            // Clear the screen
            g.FillRectangle(Brushes.DarkSlateBlue, e.ClipRectangle);

            if (!mouseOverWindow)
            {
                var font = new Font(form.Font.FontFamily, 72);
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
            g.DrawString($"Score: {score}", form.Font, Brushes.White, 5, 5);
            g.DrawString($"Lives: {livesLeft}", form.Font, Brushes.White, 5, 15 + form.Font.Size);
        }

        public override void Update()
        {
            // Increment the score
            score++;

            // Remove the planets that have fallen off of the screen
            // We use a reverse for loop so that, when we remove planets, we dont skip any
            for (int i = planets.Count - 1; i >= 0; i--)
            {
                if (planets[i].Position.Y > form.ClientSize.Height)
                    planets.RemoveAt(i);
            }

            // Speed up the planets with the score
            Planet.Speed = 10 + score / 500f;

            // Loop through the stars and update them
            foreach (var star in stars)
            {
                star.Update(form.ClientSize);
            }

            // Loop through the planets and update them
            foreach (var planet in planets)
            {
                planet.Update(form.ClientSize);
            }

            // Update our spaceship
            spaceship.Update(form.ClientSize);

            // Check for collisions
            if (CheckCollisions())
            {
                // Remove all of the planets and decrement lifeCount
                planets.Clear();
                livesLeft--;

                // Disable updates while we prompt the user
                PlanetTimer.Enabled = false;
                StarTimer.Enabled = false;

                // Check if we are out of lives
                if (livesLeft <= 0)
                {
                    // Tell the user he/she is out of lives
                    MessageBox.Show(form, $"{username} finished with {score} points.", "Game Over");

                    // Reset the game by running the init method
                    Stop();
                    Start();
                }
                else
                {
                    // Tell the user he/she died
                    MessageBox.Show(form, "You have been hit by a planet", "You died");
                }

                // Enable the timers again
                PlanetTimer.Enabled = true;
                StarTimer.Enabled = true;
            }
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

        private void PlanetTimer_Tick(object sender, EventArgs e)
        {
            // Choose a random position for the new planet
            var xPosition = random.Next(0, form.ClientSize.Width - planetHeight);

            // Create a new planet and add it to the planets list
            var planet = new Planet(new PointF(xPosition, -planetHeight));
            planets.Add(planet);
        }

        private void StarTimer_Tick(object sender, EventArgs e)
        {
            // Choose a random position and speed for the new star
            var xPosition = random.Next(0, form.ClientSize.Width - starHeight);
            var speed = 0.25 + 0.5 * random.NextDouble();

            // Create a new star and add it to the stars list
            var star = new BackgroundStar(new PointF(xPosition, -starHeight), (float)speed);
            stars.Add(star);
        }

        public override void MouseMove(MouseEventArgs e)
        {
            // Move the spaceship to in line with the mouse
            spaceship.Position.X = e.X - spaceship.Size.Width / 2;
        }

        public override void MouseEnter()
        {
            mouseOverWindow = true;
        }

        public override void MouseLeave()
        {
            mouseOverWindow = false;
        }
    }
}
