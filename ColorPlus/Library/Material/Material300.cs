
using System.Drawing;

namespace ColorPlus.Material
{
    public struct Material300
    {
        public static readonly Material300 Empty;
        public static Colour Red { get { return new Colour(0, "Red", Color.FromArgb(229, 115, 115)); } }
        public static Colour Pink { get { return new Colour(1, "Pink", Color.FromArgb(240, 98, 146)); } }
        public static Colour Purple { get { return new Colour(2, "Purple", Color.FromArgb(186, 104, 200)); } }
        public static Colour DeepPurple { get { return new Colour(3, "Deep Purple", Color.FromArgb(149, 117, 205)); } }
        public static Colour Indigo { get { return new Colour(4, "Indigo", Color.FromArgb(121, 134, 203)); } }
        public static Colour Blue { get { return new Colour(5, "Blue", Color.FromArgb(100, 181, 246)); } }
        public static Colour LightBlue { get { return new Colour(6, "Light Blue", Color.FromArgb(79, 195, 247)); } }
        public static Colour Cyan { get { return new Colour(7, "Cyan", Color.FromArgb(77, 208, 225)); } }
        public static Colour Teal { get { return new Colour(8, "Teal", Color.FromArgb(77, 182, 172)); } }
        public static Colour Green { get { return new Colour(9, "Green", Color.FromArgb(129, 199, 132)); } }
        public static Colour LightGreen { get { return new Colour(10, "Light Green", Color.FromArgb(174, 213, 129)); } }
        public static Colour Lime { get { return new Colour(11, "Lime", Color.FromArgb(220, 231, 117)); } }
        public static Colour Yellow { get { return new Colour(12, "Yellow", Color.FromArgb(255, 241, 118)); } }
        public static Colour Amber { get { return new Colour(13, "Amber", Color.FromArgb(255, 213, 79)); } }
        public static Colour Orange { get { return new Colour(14, "Orange", Color.FromArgb(255, 183, 77)); } }
        public static Colour DeepOrange { get { return new Colour(15, "Deep Orange", Color.FromArgb(255, 138, 101)); } }
        public static Colour Brown { get { return new Colour(16, "Brown", Color.FromArgb(161, 136, 127)); } }
        public static Colour Grey { get { return new Colour(17, "Grey", Color.FromArgb(224, 224, 224)); } }
        public static Colour BlueGrey { get { return new Colour(18, "Blue Grey", Color.FromArgb(144, 164, 174)); } }

    }
}
