
using System.Drawing;

namespace ColorPlus.Material
{
    public struct Material100
    {
        public static readonly Material100 Empty;
        public static Colour Red { get { return new Colour(0, "Red", Color.FromArgb(255, 205, 210)); } }
        public static Colour Pink { get { return new Colour(1, "Pink", Color.FromArgb(248, 187, 208)); } }
        public static Colour Purple { get { return new Colour(2, "Purple", Color.FromArgb(225, 190, 231)); } }
        public static Colour DeepPurple { get { return new Colour(3, "Deep Purple", Color.FromArgb(209, 196, 233)); } }
        public static Colour Indigo { get { return new Colour(4, "Indigo", Color.FromArgb(197, 202, 233)); } }
        public static Colour Blue { get { return new Colour(5, "Blue", Color.FromArgb(187, 222, 251)); } }
        public static Colour LightBlue { get { return new Colour(6, "Light Blue", Color.FromArgb(179, 229, 252)); } }
        public static Colour Cyan { get { return new Colour(7, "Cyan", Color.FromArgb(178, 235, 242)); } }
        public static Colour Teal { get { return new Colour(8, "Teal", Color.FromArgb(178, 223, 219)); } }
        public static Colour Green { get { return new Colour(9, "Green", Color.FromArgb(200, 230, 201)); } }
        public static Colour LightGreen { get { return new Colour(10, "Light Green", Color.FromArgb(220, 237, 200)); } }
        public static Colour Lime { get { return new Colour(11, "Lime", Color.FromArgb(240, 244, 195)); } }
        public static Colour Yellow { get { return new Colour(12, "Yellow", Color.FromArgb(255, 249, 196)); } }
        public static Colour Amber { get { return new Colour(13, "Amber", Color.FromArgb(255, 236, 179)); } }
        public static Colour Orange { get { return new Colour(14, "Orange", Color.FromArgb(255, 224, 178)); } }
        public static Colour DeepOrange { get { return new Colour(15, "Deep Orange", Color.FromArgb(255, 204, 188)); } }
        public static Colour Brown { get { return new Colour(16, "Brown", Color.FromArgb(215, 204, 200)); } }
        public static Colour Grey { get { return new Colour(17, "Grey", Color.FromArgb(245, 245, 245)); } }
        public static Colour BlueGrey { get { return new Colour(18, "Blue Grey", Color.FromArgb(207, 216, 220)); } }

    }
}
