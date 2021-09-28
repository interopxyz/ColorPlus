
using System.Drawing;

namespace ColorPlus.Standards
{
    public struct Metro
    {
        public static readonly Metro Empty;
        public static Colour LightGreen { get { return new Colour(0, "Light Green", Color.FromArgb(153, 180, 51)); } }
        public static Colour Green { get { return new Colour(1, "Green", Color.FromArgb(0, 163, 0)); } }
        public static Colour DarkGreen { get { return new Colour(2, "Dark Green", Color.FromArgb(30, 113, 69)); } }
        public static Colour Magenta { get { return new Colour(3, "Magenta", Color.FromArgb(255, 0, 151)); } }
        public static Colour LightPurple { get { return new Colour(4, "Light Purple", Color.FromArgb(159, 0, 167)); } }
        public static Colour Purple { get { return new Colour(5, "Purple", Color.FromArgb(126, 56, 120)); } }
        public static Colour DarkPurple { get { return new Colour(6, "Dark Purple", Color.FromArgb(96, 60, 186)); } }
        public static Colour Darken { get { return new Colour(7, "Darken", Color.FromArgb(29, 29, 29)); } }
        public static Colour Teal { get { return new Colour(8, "Teal", Color.FromArgb(0, 171, 169)); } }
        public static Colour LightBlue { get { return new Colour(9, "Light Blue", Color.FromArgb(239, 244, 255)); } }
        public static Colour Blue { get { return new Colour(10, "Blue", Color.FromArgb(45, 137, 239)); } }
        public static Colour DarkBlue { get { return new Colour(11, "Dark Blue", Color.FromArgb(43, 87, 151)); } }
        public static Colour Yellow { get { return new Colour(12, "Yellow", Color.FromArgb(255, 196, 13)); } }
        public static Colour Orange { get { return new Colour(13, "Orange", Color.FromArgb(227, 162, 26)); } }
        public static Colour DarkOrange { get { return new Colour(14, "Dark Orange", Color.FromArgb(218, 83, 44)); } }
        public static Colour Red { get { return new Colour(15, "Red", Color.FromArgb(238, 17, 17)); } }
        public static Colour DarkRed { get { return new Colour(16, "Dark Red", Color.FromArgb(185, 29, 71)); } }

    }
}
