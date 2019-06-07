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
            spaceship = new Spaceship(new Point(10, 10));
        }
    }
}
