
using System.Drawing;

namespace ColorPlus.Tailwind
{
    public struct Tailwind300
    {
        public static readonly Tailwind300 Empty;
        public static Colour Red { get { return new Colour(0, "Red", Color.FromArgb(252, 165, 165)); } }
        public static Colour Orange { get { return new Colour(1, "Orange", Color.FromArgb(253, 186, 116)); } }
        public static Colour Amber { get { return new Colour(2, "Amber", Color.FromArgb(252, 211, 77)); } }
        public static Colour Yellow { get { return new Colour(3, "Yellow", Color.FromArgb(253, 224, 71)); } }
        public static Colour Lime { get { return new Colour(4, "Lime", Color.FromArgb(190, 242, 100)); } }
        public static Colour Green { get { return new Colour(5, "Green", Color.FromArgb(134, 239, 172)); } }
        public static Colour Emerald { get { return new Colour(6, "Emerald", Color.FromArgb(110, 231, 183)); } }
        public static Colour Teal { get { return new Colour(7, "Teal", Color.FromArgb(94, 234, 212)); } }
        public static Colour Cyan { get { return new Colour(8, "Cyan", Color.FromArgb(103, 232, 249)); } }
        public static Colour LightBlue { get { return new Colour(9, "Light Blue", Color.FromArgb(125, 211, 252)); } }
        public static Colour Blue { get { return new Colour(10, "Blue", Color.FromArgb(147, 197, 253)); } }
        public static Colour Indigo { get { return new Colour(11, "Indigo", Color.FromArgb(165, 180, 252)); } }
        public static Colour Violet { get { return new Colour(12, "Violet", Color.FromArgb(196, 181, 253)); } }
        public static Colour Purple { get { return new Colour(13, "Purple", Color.FromArgb(216, 180, 254)); } }
        public static Colour Fuchsia { get { return new Colour(14, "Fuchsia", Color.FromArgb(240, 171, 252)); } }
        public static Colour Pink { get { return new Colour(15, "Pink", Color.FromArgb(249, 168, 212)); } }
        public static Colour Rose { get { return new Colour(16, "Rose", Color.FromArgb(253, 164, 175)); } }
        public static Colour WarmGray { get { return new Colour(17, "Warm Gray", Color.FromArgb(214, 211, 209)); } }
        public static Colour TrueGray { get { return new Colour(18, "True Gray", Color.FromArgb(212, 212, 212)); } }
        public static Colour Gray { get { return new Colour(19, "Gray", Color.FromArgb(212, 212, 216)); } }
        public static Colour CoolGray { get { return new Colour(20, "Cool Gray", Color.FromArgb(209, 213, 219)); } }
        public static Colour BlueGray { get { return new Colour(21, "Blue Gray", Color.FromArgb(203, 213, 225)); } }

    }
}
