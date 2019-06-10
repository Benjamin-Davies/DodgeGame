using DodgeGame.Properties;
using System.Drawing;

namespace DodgeGame
{
    class Spaceship
    {
        public Point Position;

        public Spaceship(Point position)
        {
            Position = position;
        }

        public void Draw(Graphics g)
        {
            g.DrawImage(Resources.alien1, Position);
        }
    }
}
