using System.Drawing;

namespace DodgeGame
{
    /// <summary>
    /// A abstract sprite class with all of the shared methods and
    /// properties of sprites (eg. planets and spaceships)
    /// </summary>
    abstract class Sprite
    {
        public PointF Position;
        public SizeF Size => Image.Size;
        public RectangleF Rectangle => new RectangleF(Position, Size);
        public Image Image;

        protected Sprite(Image image)
        {
            Image = image;
            Position = new PointF();
        }

        public virtual void Update(SizeF windowSize) { }

        public virtual void Draw(Graphics g)
        {
            g.DrawImage(Image, Rectangle);
        }
    }
}