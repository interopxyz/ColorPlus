
using System.Drawing;

namespace ColorPlus.Tailwind
{
    public struct Tailwind200
    {
        public static readonly Tailwind200 Empty;
        public static Colour Red { get { return new Colour(0, "Red", Color.FromArgb(254, 202, 202)); } }
        public static Colour Orange { get { return new Colour(1, "Orange", Color.FromArgb(254, 215, 170)); } }
        public static Colour Amber { get { return new Colour(2, "Amber", Color.FromArgb(253, 230, 138)); } }
        public static Colour Yellow { get { return new Colour(3, "Yellow", Color.FromArgb(254, 240, 138)); } }
        public static Colour Lime { get { return new Colour(4, "Lime", Color.FromArgb(217, 249, 157)); } }
        public static Colour Green { get { return new Colour(5, "Green", Color.FromArgb(187, 247, 208)); } }
        public static Colour Emerald { get { return new Colour(6, "Emerald", Color.FromArgb(167, 243, 208)); } }
        public static Colour Teal { get { return new Colour(7, "Teal", Color.FromArgb(153, 246, 228)); } }
        public static Colour Cyan { get { return new Colour(8, "Cyan", Color.FromArgb(165, 243, 252)); } }
        public static Colour LightBlue { get { return new Colour(9, "Light Blue", Color.FromArgb(186, 230, 253)); } }
        public static Colour Blue { get { return new Colour(10, "Blue", Color.FromArgb(191, 219, 254)); } }
        public static Colour Indigo { get { return new Colour(11, "Indigo", Color.FromArgb(199, 210, 254)); } }
        public static Colour Violet { get { return new Colour(12, "Violet", Color.FromArgb(221, 214, 254)); } }
        public static Colour Purple { get { return new Colour(13, "Purple", Color.FromArgb(233, 213, 255)); } }
        public static Colour Fuchsia { get { return new Colour(14, "Fuchsia", Color.FromArgb(245, 208, 254)); } }
        public static Colour Pink { get { return new Colour(15, "Pink", Color.FromArgb(251, 207, 232)); } }
        public static Colour Rose { get { return new Colour(16, "Rose", Color.FromArgb(254, 205, 211)); } }
        public static Colour WarmGray { get { return new Colour(17, "Warm Gray", Color.FromArgb(231, 229, 228)); } }
        public static Colour TrueGray { get { return new Colour(18, "True Gray", Color.FromArgb(229, 229, 229)); } }
        public static Colour Gray { get { return new Colour(19, "Gray", Color.FromArgb(228, 228, 231)); } }
        public static Colour CoolGray { get { return new Colour(20, "Cool Gray", Color.FromArgb(229, 231, 235)); } }
        public static Colour BlueGray { get { return new Colour(21, "Blue Gray", Color.FromArgb(226, 232, 240)); } }

    }
}
