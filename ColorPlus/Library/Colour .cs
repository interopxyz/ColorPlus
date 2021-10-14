
using System.Drawing;

namespace ColorPlus
{
    public class Colour
    {
        protected string name = "Green Beige";
        protected int index = 1000;
        protected Color color = Color.FromArgb(190, 189, 127);

        public Colour(int index, string name, Color color) : base()
        {
            this.name = name;
            this.index = index;
            this.color = color;
        }

        public virtual string Name
        {
            get { return name; }
        }

        public virtual int Index
        {
            get { return index; }
        }

        public virtual Color Color
        {
            get { return color; }
        }

    }
}