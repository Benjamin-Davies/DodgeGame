using System.ComponentModel;
using System.Windows.Forms;

namespace DodgeGame
{
    abstract class Scene
    {
        protected IContainer components;

        public abstract void Update();
        public abstract void Paint(PaintEventArgs e);

        public virtual void Start()
        {
            components = new Container();
        }
        public virtual void Stop()
        {
            components.Dispose();
            components = null;
        }

        public virtual void MouseMove(MouseEventArgs e) { }
        public virtual void MouseEnter() { }
        public virtual void MouseLeave() { }
    }
}
