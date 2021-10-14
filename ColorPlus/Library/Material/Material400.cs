
using System.Drawing;

namespace ColorPlus.Material
{
    public struct Material400
    {
        public static readonly Material400 Empty;
        public static Colour Red { get { return new Colour(0, "Red", Color.FromArgb(239, 83, 80)); } }
        public static Colour Pink { get { return new Colour(1, "Pink", Color.FromArgb(236, 64, 122)); } }
        public static Colour Purple { get { return new Colour(2, "Purple", Color.FromArgb(171, 71, 188)); } }
        public static Colour DeepPurple { get { return new Colour(3, "Deep Purple", Color.FromArgb(126, 87, 194)); } }
        public static Colour Indigo { get { return new Colour(4, "Indigo", Color.FromArgb(92, 107, 192)); } }
        public static Colour Blue { get { return new Colour(5, "Blue", Color.FromArgb(66, 165, 245)); } }
        public static Colour LightBlue { get { return new Colour(6, "Light Blue", Color.FromArgb(41, 182, 246)); } }
        public static Colour Cyan { get { return new Colour(7, "Cyan", Color.FromArgb(38, 198, 218)); } }
        public static Colour Teal { get { return new Colour(8, "Teal", Color.FromArgb(38, 166, 154)); } }
        public static Colour Green { get { return new Colour(9, "Green", Color.FromArgb(102, 187, 106)); } }
        public static Colour LightGreen { get { return new Colour(10, "Light Green", Color.FromArgb(156, 204, 101)); } }
        public static Colour Lime { get { return new Colour(11, "Lime", Color.FromArgb(212, 225, 87)); } }
        public static Colour Yellow { get { return new Colour(12, "Yellow", Color.FromArgb(255, 238, 88)); } }
        public static Colour Amber { get { return new Colour(13, "Amber", Color.FromArgb(255, 202, 40)); } }
        public static Colour Orange { get { return new Colour(14, "Orange", Color.FromArgb(255, 167, 38)); } }
        public static Colour DeepOrange { get { return new Colour(15, "Deep Orange", Color.FromArgb(255, 112, 67)); } }
        public static Colour Brown { get { return new Colour(16, "Brown", Color.FromArgb(141, 110, 99)); } }
        public static Colour Grey { get { return new Colour(17, "Grey", Color.FromArgb(189, 189, 189)); } }
        public static Colour BlueGrey { get { return new Colour(18, "Blue Grey", Color.FromArgb(120, 144, 156)); } }

    }
}
