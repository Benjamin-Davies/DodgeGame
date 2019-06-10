﻿using DodgeGame.Properties;
using System.Drawing;

namespace DodgeGame
{
    class Planet
    {
        public Point Position;

        public Planet(Point position)
        {
            Position = position;
        }

        public void Draw(Graphics g)
        {
            g.DrawImage(Resources.planet1, Position);
        }
    }
}
