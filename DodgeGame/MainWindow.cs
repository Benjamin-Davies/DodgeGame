using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace DodgeGame
{
    public partial class MainWindow : Form
    {
        private int score;
        private int livesLeft;
        private List<Planet> planets;
        private Spaceship spaceship;
        
        public MainWindow()
        {
            InitializeComponent();

            score = 0;
            livesLeft = 0;

            planets = new List<Planet>();
            for (int i = 0; i < 8; i++)
            {
                planets.Add(new Planet(new Point(100 * i, 0)));
            }

            spaceship = new Spaceship(new Point(0, 100));
        }
    }
}
