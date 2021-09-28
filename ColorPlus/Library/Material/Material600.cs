
using System.Drawing;

namespace ColorPlus.Material
{
    public struct Material600
    {
        public static readonly Material600 Empty;
        public static Colour Red { get { return new Colour(0, "Red", Color.FromArgb(229, 57, 53)); } }
        public static Colour Pink { get { return new Colour(1, "Pink", Color.FromArgb(216, 27, 96)); } }
        public static Colour Purple { get { return new Colour(2, "Purple", Color.FromArgb(142, 36, 170)); } }
        public static Colour DeepPurple { get { return new Colour(3, "Deep Purple", Color.FromArgb(94, 53, 177)); } }
        public static Colour Indigo { get { return new Colour(4, "Indigo", Color.FromArgb(57, 73, 171)); } }
        public static Colour Blue { get { return new Colour(5, "Blue", Color.FromArgb(30, 136, 229)); } }
        public static Colour LightBlue { get { return new Colour(6, "Light Blue", Color.FromArgb(3, 155, 229)); } }
        public static Colour Cyan { get { return new Colour(7, "Cyan", Color.FromArgb(0, 172, 193)); } }
        public static Colour Teal { get { return new Colour(8, "Teal", Color.FromArgb(0, 137, 123)); } }
        public static Colour Green { get { return new Colour(9, "Green", Color.FromArgb(67, 160, 71)); } }
        public static Colour LightGreen { get { return new Colour(10, "Light Green", Color.FromArgb(124, 179, 66)); } }
        public static Colour Lime { get { return new Colour(11, "Lime", Color.FromArgb(192, 202, 51)); } }
        public static Colour Yellow { get { return new Colour(12, "Yellow", Color.FromArgb(253, 216, 53)); } }
        public static Colour Amber { get { return new Colour(13, "Amber", Color.FromArgb(255, 179, 0)); } }
        public static Colour Orange { get { return new Colour(14, "Orange", Color.FromArgb(251, 140, 0)); } }
        public static Colour DeepOrange { get { return new Colour(15, "Deep Orange", Color.FromArgb(244, 81, 30)); } }
        public static Colour Brown { get { return new Colour(16, "Brown", Color.FromArgb(109, 76, 65)); } }
        public static Colour Grey { get { return new Colour(17, "Grey", Color.FromArgb(117, 117, 117)); } }
        public static Colour BlueGrey { get { return new Colour(18, "Blue Grey", Color.FromArgb(84, 110, 122)); } }

    }
}
