
using System.Drawing;

namespace ColorPlus.Material
{
    public struct MaterialA400
    {
        public static readonly MaterialA400 Empty;
        public static Colour Red { get { return new Colour(0, "Red", Color.FromArgb(255, 23, 68)); } }
        public static Colour Pink { get { return new Colour(1, "Pink", Color.FromArgb(245, 0, 87)); } }
        public static Colour Purple { get { return new Colour(2, "Purple", Color.FromArgb(213, 0, 249)); } }
        public static Colour DeepPurple { get { return new Colour(3, "Deep Purple", Color.FromArgb(101, 31, 255)); } }
        public static Colour Indigo { get { return new Colour(4, "Indigo", Color.FromArgb(61, 90, 254)); } }
        public static Colour Blue { get { return new Colour(5, "Blue", Color.FromArgb(41, 121, 255)); } }
        public static Colour LightBlue { get { return new Colour(6, "Light Blue", Color.FromArgb(0, 176, 255)); } }
        public static Colour Cyan { get { return new Colour(7, "Cyan", Color.FromArgb(0, 229, 255)); } }
        public static Colour Teal { get { return new Colour(8, "Teal", Color.FromArgb(29, 233, 182)); } }
        public static Colour Green { get { return new Colour(9, "Green", Color.FromArgb(0, 230, 118)); } }
        public static Colour LightGreen { get { return new Colour(10, "Light Green", Color.FromArgb(118, 255, 3)); } }
        public static Colour Lime { get { return new Colour(11, "Lime", Color.FromArgb(198, 255, 0)); } }
        public static Colour Yellow { get { return new Colour(12, "Yellow", Color.FromArgb(255, 234, 0)); } }
        public static Colour Amber { get { return new Colour(13, "Amber", Color.FromArgb(255, 196, 0)); } }
        public static Colour Orange { get { return new Colour(14, "Orange", Color.FromArgb(255, 145, 0)); } }
        public static Colour DeepOrange { get { return new Colour(15, "Deep Orange", Color.FromArgb(255, 61, 0)); } }

    }
}
