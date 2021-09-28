
using System.Drawing;

namespace ColorPlus.Material
{
    public struct MaterialA200
    {
        public static readonly MaterialA200 Empty;
        public static Colour Red { get { return new Colour(0, "Red", Color.FromArgb(255, 82, 82)); } }
        public static Colour Pink { get { return new Colour(1, "Pink", Color.FromArgb(255, 64, 129)); } }
        public static Colour Purple { get { return new Colour(2, "Purple", Color.FromArgb(224, 64, 251)); } }
        public static Colour DeepPurple { get { return new Colour(3, "Deep Purple", Color.FromArgb(124, 77, 255)); } }
        public static Colour Indigo { get { return new Colour(4, "Indigo", Color.FromArgb(83, 109, 254)); } }
        public static Colour Blue { get { return new Colour(5, "Blue", Color.FromArgb(68, 138, 255)); } }
        public static Colour LightBlue { get { return new Colour(6, "Light Blue", Color.FromArgb(64, 196, 255)); } }
        public static Colour Cyan { get { return new Colour(7, "Cyan", Color.FromArgb(24, 255, 255)); } }
        public static Colour Teal { get { return new Colour(8, "Teal", Color.FromArgb(100, 255, 218)); } }
        public static Colour Green { get { return new Colour(9, "Green", Color.FromArgb(105, 240, 174)); } }
        public static Colour LightGreen { get { return new Colour(10, "Light Green", Color.FromArgb(178, 255, 89)); } }
        public static Colour Lime { get { return new Colour(11, "Lime", Color.FromArgb(238, 255, 65)); } }
        public static Colour Yellow { get { return new Colour(12, "Yellow", Color.FromArgb(255, 255, 0)); } }
        public static Colour Amber { get { return new Colour(13, "Amber", Color.FromArgb(255, 215, 64)); } }
        public static Colour Orange { get { return new Colour(14, "Orange", Color.FromArgb(255, 171, 64)); } }
        public static Colour DeepOrange { get { return new Colour(15, "Deep Orange", Color.FromArgb(255, 110, 64)); } }

    }
}
