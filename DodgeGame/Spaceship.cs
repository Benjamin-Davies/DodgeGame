using DodgeGame.Properties;
using System.Drawing;

namespace DodgeGame
{
    /// <summary>
    /// A spaceship object
    /// </summary>
    class Spaceship
    {
        public Point Position;
        public Size Size;
        public Rectangle Rectangle => new Rectangle(Position, Size);

        public Spaceship(Point position)
        {
            Position = position;
            Size = Resources.alien1.Size;
        }

        public void Draw(Graphics g)
        {
            g.DrawImage(Resources.alien1, Position);
        }
    }
}
