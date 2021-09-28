
using System.Drawing;

namespace ColorPlus.Material
{
    public struct Material050
    {
        public static readonly Material050 Empty;
        public static Colour Red { get { return new Colour(0, "Red", Color.FromArgb(255, 235, 238)); } }
        public static Colour Pink { get { return new Colour(1, "Pink", Color.FromArgb(252, 228, 236)); } }
        public static Colour Purple { get { return new Colour(2, "Purple", Color.FromArgb(243, 229, 245)); } }
        public static Colour DeepPurple { get { return new Colour(3, "Deep Purple", Color.FromArgb(237, 231, 246)); } }
        public static Colour Indigo { get { return new Colour(4, "Indigo", Color.FromArgb(232, 234, 246)); } }
        public static Colour Blue { get { return new Colour(5, "Blue", Color.FromArgb(227, 242, 253)); } }
        public static Colour LightBlue { get { return new Colour(6, "Light Blue", Color.FromArgb(225, 245, 254)); } }
        public static Colour Cyan { get { return new Colour(7, "Cyan", Color.FromArgb(224, 247, 250)); } }
        public static Colour Teal { get { return new Colour(8, "Teal", Color.FromArgb(224, 242, 241)); } }
        public static Colour Green { get { return new Colour(9, "Green", Color.FromArgb(232, 245, 233)); } }
        public static Colour LightGreen { get { return new Colour(10, "Light Green", Color.FromArgb(241, 248, 233)); } }
        public static Colour Lime { get { return new Colour(11, "Lime", Color.FromArgb(249, 251, 231)); } }
        public static Colour Yellow { get { return new Colour(12, "Yellow", Color.FromArgb(255, 253, 231)); } }
        public static Colour Amber { get { return new Colour(13, "Amber", Color.FromArgb(255, 248, 225)); } }
        public static Colour Orange { get { return new Colour(14, "Orange", Color.FromArgb(255, 243, 224)); } }
        public static Colour DeepOrange { get { return new Colour(15, "Deep Orange", Color.FromArgb(251, 233, 231)); } }
        public static Colour Brown { get { return new Colour(16, "Brown", Color.FromArgb(239, 235, 233)); } }
        public static Colour Grey { get { return new Colour(17, "Grey", Color.FromArgb(250, 250, 250)); } }
        public static Colour BlueGrey { get { return new Colour(18, "Blue Grey", Color.FromArgb(236, 239, 241)); } }

    }
}
