using DodgeGame.Properties;
using System;
using System.Drawing;

namespace DodgeGame
{
    /// <summary>
    /// A planet object
    /// </summary>
    class Planet : Sprite
    {
        public float Speed = 10;

        public Planet(PointF position) : base(Resources.planet1)
        {
            Position = position;
        }

        public override void Update(SizeF windowSize)
        {
            Position.Y += Speed;
        }

        public bool CollidesWith(RectangleF spaceship)
        {
            var circle1 = Circle.FromRect(Rectangle);
            var circle2 = Circle.FromRect(spaceship);
            return circle1.IntersectsWith(circle2);
        }

        private class Circle
        {
            public PointF Center;
            public float Radius;

            public static Circle FromRect(RectangleF rectangle)
            {
                // Inscribes a circle in the smallest square that contains the
                // rectangle and shares a center.
                float radius = rectangle.Width > rectangle.Height
                    ? rectangle.Width / 2
                    : rectangle.Height / 2;
                var center = new PointF(
                    rectangle.X - rectangle.Width / 2,
                    rectangle.Y - rectangle.Height / 2
                );

                return new Circle
                {
                    Center = center,
                    Radius = radius
                };
            }

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
