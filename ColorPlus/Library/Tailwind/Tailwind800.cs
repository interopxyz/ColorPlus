
using System.Drawing;

namespace ColorPlus.Tailwind
{
    public struct Tailwind800
    {
        public static readonly Tailwind800 Empty;
        public static Colour Red { get { return new Colour(0, "Red", Color.FromArgb(153, 27, 27)); } }
        public static Colour Orange { get { return new Colour(1, "Orange", Color.FromArgb(154, 52, 18)); } }
        public static Colour Amber { get { return new Colour(2, "Amber", Color.FromArgb(146, 64, 14)); } }
        public static Colour Yellow { get { return new Colour(3, "Yellow", Color.FromArgb(133, 77, 14)); } }
        public static Colour Lime { get { return new Colour(4, "Lime", Color.FromArgb(63, 98, 18)); } }
        public static Colour Green { get { return new Colour(5, "Green", Color.FromArgb(22, 101, 52)); } }
        public static Colour Emerald { get { return new Colour(6, "Emerald", Color.FromArgb(6, 95, 70)); } }
        public static Colour Teal { get { return new Colour(7, "Teal", Color.FromArgb(17, 94, 89)); } }
        public static Colour Cyan { get { return new Colour(8, "Cyan", Color.FromArgb(21, 94, 117)); } }
        public static Colour LightBlue { get { return new Colour(9, "Light Blue", Color.FromArgb(7, 89, 133)); } }
        public static Colour Blue { get { return new Colour(10, "Blue", Color.FromArgb(30, 64, 175)); } }
        public static Colour Indigo { get { return new Colour(11, "Indigo", Color.FromArgb(55, 48, 163)); } }
        public static Colour Violet { get { return new Colour(12, "Violet", Color.FromArgb(91, 33, 182)); } }
        public static Colour Purple { get { return new Colour(13, "Purple", Color.FromArgb(134, 25, 143)); } }
        public static Colour Fuchsia { get { return new Colour(14, "Fuchsia", Color.FromArgb(134, 25, 143)); } }
        public static Colour Pink { get { return new Colour(15, "Pink", Color.FromArgb(157, 23, 77)); } }
        public static Colour Rose { get { return new Colour(16, "Rose", Color.FromArgb(159, 18, 57)); } }
        public static Colour WarmGray { get { return new Colour(17, "Warm Gray", Color.FromArgb(41, 37, 36)); } }
        public static Colour TrueGray { get { return new Colour(18, "True Gray", Color.FromArgb(38, 38, 38)); } }
        public static Colour Gray { get { return new Colour(19, "Gray", Color.FromArgb(39, 39, 42)); } }
        public static Colour CoolGray { get { return new Colour(20, "Cool Gray", Color.FromArgb(31, 41, 55)); } }
        public static Colour BlueGray { get { return new Colour(21, "Blue Gray", Color.FromArgb(30, 41, 59)); } }

    }
}
