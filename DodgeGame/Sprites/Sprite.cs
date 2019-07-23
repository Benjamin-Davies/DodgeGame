using System.Drawing;

namespace DodgeGame.Sprites
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

        /// <summary>
        /// Method to overide to update the sprite
        /// </summary>
        public virtual void Update(SizeF windowSize) { }

        /// <summary>
        /// Draw the sprite
        /// </summary>
        public virtual void Draw(Graphics g)
        {
            g.DrawImage(Image, Rectangle);
        }
    }
}