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
        private const int planetWidth = 77;

        // Member variables for storing the state of the game
        private string username;
        private int score;
        private int livesLeft;
        private List<Planet> planets;
        private Spaceship spaceship;
        private Random random;

        public MainWindow()
        {
            // Built in method to construct UI from designer
            InitializeComponent();

            // Init variables
            username = "";
            score = 0;
            livesLeft = 0;

            // Create a list of planets
            planets = new List<Planet>();

            // Create a spaceship
            spaceship = new Spaceship();

            // Initialize a random number generator
            random = new Random();
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
            PlanetTimer.Enabled = true;
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
            // Remove the planets that have fallen off of the screen
            // We use a reverse for loop so that, when we remove planets, we dont skip any
            for (int i = planets.Count - 1; i >= 0; i--)
            {
                if (planets[i].Position.Y > Height)
                    planets.RemoveAt(i);
            }

            // Loop through the planets and update them
            foreach (var planet in planets)
            {
                planet.Update();
            }

            // Update our spaceship
            spaceship.Update();

            // Tell the window to redraw
            Invalidate();
        }

        private void MainWindow_MouseMove(object sender, MouseEventArgs e)
        {
            // Move the spaceship to in line with the mouse
            spaceship.Position.X = e.X - spaceship.Size.Width / 2;
        }

        private void PlanetTimer_Tick(object sender, EventArgs e)
        {
            // Choose a random position for the new planet
            var xPosition = random.Next(0, Width - planetWidth);

            // Create a new planet and add it to the planets list
            var planet = new Planet(new PointF(xPosition, -planetWidth));
            planets.Add(planet);
        }
    }
}