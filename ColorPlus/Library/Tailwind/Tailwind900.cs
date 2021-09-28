
using System.Drawing;

namespace ColorPlus.Tailwind
{
    public struct Tailwind900
    {
        public static readonly Tailwind900 Empty;
        public static Colour Red { get { return new Colour(0, "Red", Color.FromArgb(127, 29, 29)); } }
        public static Colour Orange { get { return new Colour(1, "Orange", Color.FromArgb(124, 45, 18)); } }
        public static Colour Amber { get { return new Colour(2, "Amber", Color.FromArgb(120, 53, 15)); } }
        public static Colour Yellow { get { return new Colour(3, "Yellow", Color.FromArgb(113, 63, 18)); } }
        public static Colour Lime { get { return new Colour(4, "Lime", Color.FromArgb(54, 83, 20)); } }
        public static Colour Green { get { return new Colour(5, "Green", Color.FromArgb(20, 83, 45)); } }
        public static Colour Emerald { get { return new Colour(6, "Emerald", Color.FromArgb(6, 78, 59)); } }
        public static Colour Teal { get { return new Colour(7, "Teal", Color.FromArgb(19, 78, 74)); } }
        public static Colour Cyan { get { return new Colour(8, "Cyan", Color.FromArgb(22, 78, 99)); } }
        public static Colour LightBlue { get { return new Colour(9, "Light Blue", Color.FromArgb(12, 74, 110)); } }
        public static Colour Blue { get { return new Colour(10, "Blue", Color.FromArgb(30, 58, 138)); } }
        public static Colour Indigo { get { return new Colour(11, "Indigo", Color.FromArgb(49, 46, 129)); } }
        public static Colour Violet { get { return new Colour(12, "Violet", Color.FromArgb(76, 29, 149)); } }
        public static Colour Purple { get { return new Colour(13, "Purple", Color.FromArgb(88, 28, 135)); } }
        public static Colour Fuchsia { get { return new Colour(14, "Fuchsia", Color.FromArgb(112, 26, 117)); } }
        public static Colour Pink { get { return new Colour(15, "Pink", Color.FromArgb(131, 24, 67)); } }
        public static Colour Rose { get { return new Colour(16, "Rose", Color.FromArgb(136, 19, 55)); } }
        public static Colour WarmGray { get { return new Colour(17, "Warm Gray", Color.FromArgb(28, 25, 23)); } }
        public static Colour TrueGray { get { return new Colour(18, "True Gray", Color.FromArgb(23, 23, 23)); } }
        public static Colour Gray { get { return new Colour(19, "Gray", Color.FromArgb(24, 24, 27)); } }
        public static Colour CoolGray { get { return new Colour(20, "Cool Gray", Color.FromArgb(17, 24, 39)); } }
        public static Colour BlueGray { get { return new Colour(21, "Blue Gray", Color.FromArgb(15, 23, 42)); } }

    }
}
