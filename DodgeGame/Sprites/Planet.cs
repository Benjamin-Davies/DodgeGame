using DodgeGame.Properties;
using System;
using System.Drawing;

namespace DodgeGame.Sprites
{
    /// <summary>
    /// A planet object
    /// </summary>
    class Planet : Sprite
    {
        /// <summary>
        /// Static so that all planets have the same speed
        /// </summary>
        public static float Speed = 10;

        public Planet(PointF position) : base(Resources.planet1)
        {
            Position = position;
        }

        /// <summary>
        /// Update the planet's position
        /// </summary>
        public override void Update(SizeF windowSize)
        {
            Position.Y += Speed;
        }

        /// <summary>
        /// Check if the planet collides with the given spaceship
        /// </summary>
        public bool CollidesWith(RectangleF spaceship)
        {
            var circle1 = Circle.FromRect(Rectangle);
            var circle2 = Circle.FromRect(spaceship);
            return circle1.IntersectsWith(circle2);
        }

        /// <summary>
        /// Circle class to help with collision detection
        /// </summary>
        private class Circle
        {
            public PointF Center;
            public float Radius;

            /// <summary>
            /// Get an inscribed circle from the given rectangle
            /// </summary>
            public static Circle FromRect(RectangleF rectangle)
            {
                // Inscribes a circle in the smallest square that contains the
                // rectangle and shares a center.
                float radius = rectangle.Width > rectangle.Height
                    ? rectangle.Width / 2
                    : rectangle.Height / 2;
                var center = new PointF(
                    rectangle.X + rectangle.Width / 2,
                    rectangle.Y + rectangle.Height / 2
                );

                return new Circle
                {
                    Center = center,
                    Radius = radius
                };
            }

            /// <summary>
            /// Check if the circle intersects with another circle
            /// </summary>
            public bool IntersectsWith(Circle other)
            {
                // Compare the distance between centers to the sum of the radii
                float dx = Center.X - other.Center.X;
                float dy = Center.Y - other.Center.Y;
                float sumR = Radius + other.Radius;
                return dx * dx + dy * dy <= sumR * sumR;
            }
        }
    }
}
