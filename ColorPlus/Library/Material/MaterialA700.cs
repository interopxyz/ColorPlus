
using System.Drawing;

namespace ColorPlus.Material
{
    public struct MaterialA700
    {
        public static readonly MaterialA700 Empty;
        public static Colour Red { get { return new Colour(0, "Red", Color.FromArgb(213, 0, 0)); } }
        public static Colour Pink { get { return new Colour(1, "Pink", Color.FromArgb(197, 17, 98)); } }
        public static Colour Purple { get { return new Colour(2, "Purple", Color.FromArgb(170, 0, 255)); } }
        public static Colour DeepPurple { get { return new Colour(3, "Deep Purple", Color.FromArgb(98, 0, 234)); } }
        public static Colour Indigo { get { return new Colour(4, "Indigo", Color.FromArgb(48, 79, 254)); } }
        public static Colour Blue { get { return new Colour(5, "Blue", Color.FromArgb(41, 98, 255)); } }
        public static Colour LightBlue { get { return new Colour(6, "Light Blue", Color.FromArgb(0, 145, 234)); } }
        public static Colour Cyan { get { return new Colour(7, "Cyan", Color.FromArgb(0, 184, 212)); } }
        public static Colour Teal { get { return new Colour(8, "Teal", Color.FromArgb(0, 191, 165)); } }
        public static Colour Green { get { return new Colour(9, "Green", Color.FromArgb(0, 200, 83)); } }
        public static Colour LightGreen { get { return new Colour(10, "Light Green", Color.FromArgb(100, 221, 23)); } }
        public static Colour Lime { get { return new Colour(11, "Lime", Color.FromArgb(174, 234, 0)); } }
        public static Colour Yellow { get { return new Colour(12, "Yellow", Color.FromArgb(174, 234, 0)); } }
        public static Colour Amber { get { return new Colour(13, "Amber", Color.FromArgb(255, 171, 0)); } }
        public static Colour Orange { get { return new Colour(14, "Orange", Color.FromArgb(255, 109, 0)); } }
        public static Colour DeepOrange { get { return new Colour(15, "Deep Orange", Color.FromArgb(221, 44, 0)); } }

    }
}
