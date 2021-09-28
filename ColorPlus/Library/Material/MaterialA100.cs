
using System.Drawing;

namespace ColorPlus.Material
{
    public struct MaterialA100
    {
        public static readonly MaterialA100 Empty;
        public static Colour Red { get { return new Colour(0, "Red", Color.FromArgb(255, 138, 128)); } }
        public static Colour Pink { get { return new Colour(1, "Pink", Color.FromArgb(255, 128, 171)); } }
        public static Colour Purple { get { return new Colour(2, "Purple", Color.FromArgb(234, 128, 252)); } }
        public static Colour DeepPurple { get { return new Colour(3, "Deep Purple", Color.FromArgb(179, 136, 255)); } }
        public static Colour Indigo { get { return new Colour(4, "Indigo", Color.FromArgb(140, 158, 255)); } }
        public static Colour Blue { get { return new Colour(5, "Blue", Color.FromArgb(130, 177, 255)); } }
        public static Colour LightBlue { get { return new Colour(6, "Light Blue", Color.FromArgb(128, 216, 255)); } }
        public static Colour Cyan { get { return new Colour(7, "Cyan", Color.FromArgb(132, 255, 255)); } }
        public static Colour Teal { get { return new Colour(8, "Teal", Color.FromArgb(167, 255, 235)); } }
        public static Colour Green { get { return new Colour(9, "Green", Color.FromArgb(185, 246, 202)); } }
        public static Colour LightGreen { get { return new Colour(10, "Light Green", Color.FromArgb(204, 255, 144)); } }
        public static Colour Lime { get { return new Colour(11, "Lime", Color.FromArgb(244, 255, 129)); } }
        public static Colour Yellow { get { return new Colour(12, "Yellow", Color.FromArgb(255, 255, 141)); } }
        public static Colour Amber { get { return new Colour(13, "Amber", Color.FromArgb(255, 229, 127)); } }
        public static Colour Orange { get { return new Colour(14, "Orange", Color.FromArgb(255, 209, 128)); } }
        public static Colour DeepOrange { get { return new Colour(15, "Deep Orange", Color.FromArgb(255, 158, 128)); } }

    }
}
