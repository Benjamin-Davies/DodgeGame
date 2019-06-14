using System.Drawing;

namespace DodgeGame
{
    /// <summary>
    /// A abstract sprite class with all of the shared methods and
    /// properties of sprites (eg. planets and spaceships)
    /// </summary>
    abstract class Sprite
    {
        public Point Position;
        public Size Size => Image.Size;
        public Rectangle Rectangle => new Rectangle(Position, Size);
        public Image Image;

        protected Sprite(Image image)
        {
            Image = image;
            Position = new Point();
        }

        public virtual void Update() { }

        public virtual void Draw(Graphics g)
        {
            g.DrawImage(Image, Rectangle);
        }
    }
}