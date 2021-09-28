
using System.Drawing;

namespace ColorPlus.D3.SequentialSingle
{
    public struct Reds
    {
        public static readonly Reds Empty;
        public static Colour Reds000 { get { return new Colour(25, "Reds000", Color.FromArgb(255, 245, 240)); } }
        public static Colour Reds025 { get { return new Colour(26, "Reds025", Color.FromArgb(252, 186, 161)); } }
        public static Colour Reds050 { get { return new Colour(27, "Reds050", Color.FromArgb(249, 104, 75)); } }
        public static Colour Reds075 { get { return new Colour(28, "Reds075", Color.FromArgb(203, 29, 30)); } }
        public static Colour Reds100 { get { return new Colour(29, "Reds100", Color.FromArgb(103, 0, 13)); } }

    }
}