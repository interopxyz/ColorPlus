
using System.Drawing;

namespace ColorPlus.Material
{
    public struct Material500
    {
        public static readonly Material500 Empty;
        public static Colour Red { get { return new Colour(0, "Red", Color.FromArgb(244, 67, 54)); } }
        public static Colour Pink { get { return new Colour(1, "Pink", Color.FromArgb(233, 30, 99)); } }
        public static Colour Purple { get { return new Colour(2, "Purple", Color.FromArgb(156, 39, 176)); } }
        public static Colour DeepPurple { get { return new Colour(3, "Deep Purple", Color.FromArgb(103, 58, 183)); } }
        public static Colour Indigo { get { return new Colour(4, "Indigo", Color.FromArgb(63, 81, 181)); } }
        public static Colour Blue { get { return new Colour(5, "Blue", Color.FromArgb(33, 150, 243)); } }
        public static Colour LightBlue { get { return new Colour(6, "Light Blue", Color.FromArgb(3, 169, 244)); } }
        public static Colour Cyan { get { return new Colour(7, "Cyan", Color.FromArgb(0, 188, 212)); } }
        public static Colour Teal { get { return new Colour(8, "Teal", Color.FromArgb(0, 150, 136)); } }
        public static Colour Green { get { return new Colour(9, "Green", Color.FromArgb(76, 175, 80)); } }
        public static Colour LightGreen { get { return new Colour(10, "Light Green", Color.FromArgb(139, 195, 74)); } }
        public static Colour Lime { get { return new Colour(11, "Lime", Color.FromArgb(205, 220, 57)); } }
        public static Colour Yellow { get { return new Colour(12, "Yellow", Color.FromArgb(255, 235, 59)); } }
        public static Colour Amber { get { return new Colour(13, "Amber", Color.FromArgb(255, 193, 7)); } }
        public static Colour Orange { get { return new Colour(14, "Orange", Color.FromArgb(255, 152, 0)); } }
        public static Colour DeepOrange { get { return new Colour(15, "Deep Orange", Color.FromArgb(255, 87, 34)); } }
        public static Colour Brown { get { return new Colour(16, "Brown", Color.FromArgb(121, 85, 72)); } }
        public static Colour Grey { get { return new Colour(17, "Grey", Color.FromArgb(158, 158, 158)); } }
        public static Colour BlueGrey { get { return new Colour(18, "Blue Grey", Color.FromArgb(96, 125, 139)); } }

    }
}
