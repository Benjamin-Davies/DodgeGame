using DodgeGame.Properties;
using System.Drawing;

namespace DodgeGame
{
    /// <summary>
    /// A planet object
    /// </summary>
    class Planet
    {
        public Point Position;
        public Size Size;
        public Rectangle Rectangle => new Rectangle(Position, Size);

        public Planet(Point position)
        {
            Position = position;
            Size = Resources.planet1.Size;
        }

        public void Update()
        {
            Position.Y += 10;
        }

        public void Draw(Graphics g)
        {
            g.DrawImage(Resources.planet1, Position);
        }
    }
}
