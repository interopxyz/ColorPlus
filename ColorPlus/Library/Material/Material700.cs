
using System.Drawing;

namespace ColorPlus.Material
{
    public struct Material700
    {
        public static readonly Material700 Empty;
        public static Colour Red { get { return new Colour(0, "Red", Color.FromArgb(211, 47, 47)); } }
        public static Colour Pink { get { return new Colour(1, "Pink", Color.FromArgb(194, 24, 91)); } }
        public static Colour Purple { get { return new Colour(2, "Purple", Color.FromArgb(123, 31, 162)); } }
        public static Colour DeepPurple { get { return new Colour(3, "Deep Purple", Color.FromArgb(81, 45, 168)); } }
        public static Colour Indigo { get { return new Colour(4, "Indigo", Color.FromArgb(48, 63, 159)); } }
        public static Colour Blue { get { return new Colour(5, "Blue", Color.FromArgb(25, 118, 210)); } }
        public static Colour LightBlue { get { return new Colour(6, "Light Blue", Color.FromArgb(2, 136, 209)); } }
        public static Colour Cyan { get { return new Colour(7, "Cyan", Color.FromArgb(0, 151, 167)); } }
        public static Colour Teal { get { return new Colour(8, "Teal", Color.FromArgb(0, 121, 107)); } }
        public static Colour Green { get { return new Colour(9, "Green", Color.FromArgb(56, 142, 60)); } }
        public static Colour LightGreen { get { return new Colour(10, "Light Green", Color.FromArgb(104, 159, 56)); } }
        public static Colour Lime { get { return new Colour(11, "Lime", Color.FromArgb(175, 180, 43)); } }
        public static Colour Yellow { get { return new Colour(12, "Yellow", Color.FromArgb(251, 192, 45)); } }
        public static Colour Amber { get { return new Colour(13, "Amber", Color.FromArgb(255, 160, 0)); } }
        public static Colour Orange { get { return new Colour(14, "Orange", Color.FromArgb(245, 124, 0)); } }
        public static Colour DeepOrange { get { return new Colour(15, "Deep Orange", Color.FromArgb(230, 74, 25)); } }
        public static Colour Brown { get { return new Colour(16, "Brown", Color.FromArgb(93, 64, 55)); } }
        public static Colour Grey { get { return new Colour(17, "Grey", Color.FromArgb(97, 97, 97)); } }
        public static Colour BlueGrey { get { return new Colour(18, "Blue Grey", Color.FromArgb(69, 90, 100)); } }

    }
}
