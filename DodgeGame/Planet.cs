using DodgeGame.Properties;
using System.Drawing;

namespace DodgeGame
{
    /// <summary>
    /// A planet object
    /// </summary>
    class Planet : Sprite
    {
        public Planet(PointF position) : base(Resources.planet1)
        {
            Position = position;
        }

        public override void Update()
        {
            Position.Y += 10;
        }
    }
}
