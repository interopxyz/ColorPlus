
using System.Drawing;

namespace ColorPlus.Material
{
    public struct Material900
    {
        public static readonly Material900 Empty;
        public static Colour Red { get { return new Colour(0, "Red", Color.FromArgb(183, 28, 28)); } }
        public static Colour Pink { get { return new Colour(1, "Pink", Color.FromArgb(136, 14, 79)); } }
        public static Colour Purple { get { return new Colour(2, "Purple", Color.FromArgb(74, 20, 140)); } }
        public static Colour DeepPurple { get { return new Colour(3, "Deep Purple", Color.FromArgb(49, 27, 146)); } }
        public static Colour Indigo { get { return new Colour(4, "Indigo", Color.FromArgb(26, 35, 126)); } }
        public static Colour Blue { get { return new Colour(5, "Blue", Color.FromArgb(13, 71, 161)); } }
        public static Colour LightBlue { get { return new Colour(6, "Light Blue", Color.FromArgb(1, 87, 155)); } }
        public static Colour Cyan { get { return new Colour(7, "Cyan", Color.FromArgb(0, 96, 100)); } }
        public static Colour Teal { get { return new Colour(8, "Teal", Color.FromArgb(0, 77, 64)); } }
        public static Colour Green { get { return new Colour(9, "Green", Color.FromArgb(27, 94, 32)); } }
        public static Colour LightGreen { get { return new Colour(10, "Light Green", Color.FromArgb(51, 105, 30)); } }
        public static Colour Lime { get { return new Colour(11, "Lime", Color.FromArgb(130, 119, 23)); } }
        public static Colour Yellow { get { return new Colour(12, "Yellow", Color.FromArgb(245, 127, 23)); } }
        public static Colour Amber { get { return new Colour(13, "Amber", Color.FromArgb(255, 111, 0)); } }
        public static Colour Orange { get { return new Colour(14, "Orange", Color.FromArgb(230, 81, 0)); } }
        public static Colour DeepOrange { get { return new Colour(15, "Deep Orange", Color.FromArgb(191, 54, 12)); } }
        public static Colour Brown { get { return new Colour(16, "Brown", Color.FromArgb(62, 39, 35)); } }
        public static Colour Grey { get { return new Colour(17, "Grey", Color.FromArgb(33, 33, 33)); } }
        public static Colour BlueGrey { get { return new Colour(18, "Blue Grey", Color.FromArgb(38, 50, 56)); } }

    }
}
