
using System.Drawing;

namespace ColorPlus.D3.SequentialSingle
{
    public struct Greys
    {
        public static readonly Greys Empty;
        public static Colour Greys000 { get { return new Colour(10, "Greys000", Color.FromArgb(255, 255, 255)); } }
        public static Colour Greys025 { get { return new Colour(11, "Greys025", Color.FromArgb(216, 216, 216)); } }
        public static Colour Greys050 { get { return new Colour(12, "Greys050", Color.FromArgb(150, 150, 150)); } }
        public static Colour Greys075 { get { return new Colour(13, "Greys075", Color.FromArgb(80, 80, 80)); } }
        public static Colour Greys100 { get { return new Colour(14, "Greys100", Color.FromArgb(0, 0, 0)); } }

    }
}