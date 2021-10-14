
using System.Drawing;

namespace ColorPlus.Material
{
    public struct Material200
    {
        public static readonly Material200 Empty;
        public static Colour Red { get { return new Colour(0, "Red", Color.FromArgb(239, 154, 154)); } }
        public static Colour Pink { get { return new Colour(1, "Pink", Color.FromArgb(244, 143, 177)); } }
        public static Colour Purple { get { return new Colour(2, "Purple", Color.FromArgb(206, 147, 216)); } }
        public static Colour DeepPurple { get { return new Colour(3, "Deep Purple", Color.FromArgb(179, 157, 219)); } }
        public static Colour Indigo { get { return new Colour(4, "Indigo", Color.FromArgb(159, 168, 218)); } }
        public static Colour Blue { get { return new Colour(5, "Blue", Color.FromArgb(144, 202, 249)); } }
        public static Colour LightBlue { get { return new Colour(6, "Light Blue", Color.FromArgb(129, 212, 250)); } }
        public static Colour Cyan { get { return new Colour(7, "Cyan", Color.FromArgb(128, 222, 234)); } }
        public static Colour Teal { get { return new Colour(8, "Teal", Color.FromArgb(128, 203, 196)); } }
        public static Colour Green { get { return new Colour(9, "Green", Color.FromArgb(165, 214, 167)); } }
        public static Colour LightGreen { get { return new Colour(10, "Light Green", Color.FromArgb(197, 225, 165)); } }
        public static Colour Lime { get { return new Colour(11, "Lime", Color.FromArgb(230, 238, 156)); } }
        public static Colour Yellow { get { return new Colour(12, "Yellow", Color.FromArgb(255, 245, 157)); } }
        public static Colour Amber { get { return new Colour(13, "Amber", Color.FromArgb(255, 224, 130)); } }
        public static Colour Orange { get { return new Colour(14, "Orange", Color.FromArgb(255, 204, 128)); } }
        public static Colour DeepOrange { get { return new Colour(15, "Deep Orange", Color.FromArgb(255, 171, 145)); } }
        public static Colour Brown { get { return new Colour(16, "Brown", Color.FromArgb(188, 170, 164)); } }
        public static Colour Grey { get { return new Colour(17, "Grey", Color.FromArgb(238, 238, 238)); } }
        public static Colour BlueGrey { get { return new Colour(18, "Blue Grey", Color.FromArgb(176, 190, 197)); } }

    }
}
