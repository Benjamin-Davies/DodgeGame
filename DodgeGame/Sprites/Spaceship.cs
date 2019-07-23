using DodgeGame.Properties;
using System.Drawing;

namespace DodgeGame.Sprites
{
    /// <summary>
    /// A spaceship object
    /// </summary>
    class Spaceship : Sprite
    {
        public Spaceship() : base(Resources.alien1) { }

        /// <summary>
        /// Update the spaceship's position
        /// </summary>
        public override void Update(SizeF windowSize)
        {
            base.Update(windowSize);

            if (Position.X < 0)
                Position.X = 0;

            float maxX = windowSize.Width - Size.Width;
            if (Position.X > maxX)
                Position.X = maxX;

            // Update the y coordinate so that it is at the bottom of the window
            Position.Y = windowSize.Height - Size.Height;
        }
    }
}
