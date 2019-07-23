using DodgeGame.Properties;
using System.Drawing;

namespace DodgeGame.Sprites
{
    /// <summary>
    /// One of the stars in the background
    /// </summary>
    class BackgroundStar : Sprite
    {
        private float Speed = 0;

        public BackgroundStar(PointF position, float speed) : base(Resources.smallstar)
        {
            Position = position;
            Speed = speed;
        }

        /// <summary>
        /// Update the star's position
        /// </summary>
        public override void Update(SizeF windowSize)
        {
            base.Update(windowSize);

            // Speed up with the planets
            Position.Y += Speed * Planet.Speed;
        }
    }
}
