
using System.Drawing;

namespace ColorPlus.Material
{
    public struct Material800
    {
        public static readonly Material800 Empty;
        public static Colour Red { get { return new Colour(0, "Red", Color.FromArgb(198, 40, 40)); } }
        public static Colour Pink { get { return new Colour(1, "Pink", Color.FromArgb(173, 20, 87)); } }
        public static Colour Purple { get { return new Colour(2, "Purple", Color.FromArgb(106, 27, 154)); } }
        public static Colour DeepPurple { get { return new Colour(3, "Deep Purple", Color.FromArgb(69, 39, 160)); } }
        public static Colour Indigo { get { return new Colour(4, "Indigo", Color.FromArgb(40, 53, 147)); } }
        public static Colour Blue { get { return new Colour(5, "Blue", Color.FromArgb(21, 101, 192)); } }
        public static Colour LightBlue { get { return new Colour(6, "Light Blue", Color.FromArgb(2, 119, 189)); } }
        public static Colour Cyan { get { return new Colour(7, "Cyan", Color.FromArgb(0, 131, 143)); } }
        public static Colour Teal { get { return new Colour(8, "Teal", Color.FromArgb(0, 105, 92)); } }
        public static Colour Green { get { return new Colour(9, "Green", Color.FromArgb(46, 125, 50)); } }
        public static Colour LightGreen { get { return new Colour(10, "Light Green", Color.FromArgb(85, 139, 47)); } }
        public static Colour Lime { get { return new Colour(11, "Lime", Color.FromArgb(158, 157, 36)); } }
        public static Colour Yellow { get { return new Colour(12, "Yellow", Color.FromArgb(249, 168, 37)); } }
        public static Colour Amber { get { return new Colour(13, "Amber", Color.FromArgb(255, 143, 0)); } }
        public static Colour Orange { get { return new Colour(14, "Orange", Color.FromArgb(239, 108, 0)); } }
        public static Colour DeepOrange { get { return new Colour(15, "Deep Orange", Color.FromArgb(216, 67, 21)); } }
        public static Colour Brown { get { return new Colour(16, "Brown", Color.FromArgb(78, 52, 46)); } }
        public static Colour Grey { get { return new Colour(17, "Grey", Color.FromArgb(66, 66, 66)); } }
        public static Colour BlueGrey { get { return new Colour(18, "Blue Grey", Color.FromArgb(55, 71, 79)); } }

    }
}
