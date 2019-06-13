using DodgeGame.Properties;
using System.Drawing;

namespace DodgeGame
{
    /// <summary>
    /// A planet object
    /// </summary>
    class Planet : Sprite
    {
        public Planet(Point position) : base(position, Resources.planet1) { }

        public override void Update()
        {
            Position.Y += 10;
        }
    }
}
