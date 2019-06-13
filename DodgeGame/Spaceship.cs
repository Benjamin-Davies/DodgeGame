using DodgeGame.Properties;
using System.Drawing;

namespace DodgeGame
{
    /// <summary>
    /// A spaceship object
    /// </summary>
    class Spaceship : Sprite
    {
        public Spaceship(Point position) : base(position, Resources.alien1) { }
    }
}
