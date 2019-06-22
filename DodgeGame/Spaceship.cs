using DodgeGame.Properties;
using System.Drawing;

namespace DodgeGame
{
    /// <summary>
    /// A spaceship object
    /// </summary>
    class Spaceship : Sprite
    {
        public Spaceship() : base(Resources.alien1) { }

        public override void Update(SizeF windowSize)
        {
            base.Update(windowSize);

            if (Position.X < 0)
                Position.X = 0;

            float maxX = windowSize.Width - Size.Width;
            if (Position.X > maxX)
                Position.X = maxX;
        }

        public override void Draw(Graphics g)
        {
            // Update the y coordinate so that it is at the bottom of the window
            Position.Y = g.ClipBounds.Height - Size.Height;

            // Draw normally
            base.Draw(g);
        }
    }
}
