
using System.Drawing;

namespace ColorPlus.Tailwind
{
    public struct Tailwind100
    {
        public static readonly Tailwind100 Empty;
        public static Colour Red { get { return new Colour(0, "Red", Color.FromArgb(254, 226, 226)); } }
        public static Colour Orange { get { return new Colour(1, "Orange", Color.FromArgb(255, 237, 213)); } }
        public static Colour Amber { get { return new Colour(2, "Amber", Color.FromArgb(254, 243, 199)); } }
        public static Colour Yellow { get { return new Colour(3, "Yellow", Color.FromArgb(254, 249, 195)); } }
        public static Colour Lime { get { return new Colour(4, "Lime", Color.FromArgb(236, 252, 203)); } }
        public static Colour Green { get { return new Colour(5, "Green", Color.FromArgb(220, 252, 231)); } }
        public static Colour Emerald { get { return new Colour(6, "Emerald", Color.FromArgb(209, 250, 229)); } }
        public static Colour Teal { get { return new Colour(7, "Teal", Color.FromArgb(204, 251, 241)); } }
        public static Colour Cyan { get { return new Colour(8, "Cyan", Color.FromArgb(207, 250, 254)); } }
        public static Colour LightBlue { get { return new Colour(9, "Light Blue", Color.FromArgb(224, 242, 254)); } }
        public static Colour Blue { get { return new Colour(10, "Blue", Color.FromArgb(219, 234, 254)); } }
        public static Colour Indigo { get { return new Colour(11, "Indigo", Color.FromArgb(224, 231, 255)); } }
        public static Colour Violet { get { return new Colour(12, "Violet", Color.FromArgb(237, 233, 254)); } }
        public static Colour Purple { get { return new Colour(13, "Purple", Color.FromArgb(243, 232, 255)); } }
        public static Colour Fuchsia { get { return new Colour(14, "Fuchsia", Color.FromArgb(250, 232, 255)); } }
        public static Colour Pink { get { return new Colour(15, "Pink", Color.FromArgb(252, 231, 243)); } }
        public static Colour Rose { get { return new Colour(16, "Rose", Color.FromArgb(255, 228, 230)); } }
        public static Colour WarmGray { get { return new Colour(17, "Warm Gray", Color.FromArgb(245, 245, 244)); } }
        public static Colour TrueGray { get { return new Colour(18, "True Gray", Color.FromArgb(245, 245, 245)); } }
        public static Colour Gray { get { return new Colour(19, "Gray", Color.FromArgb(244, 244, 245)); } }
        public static Colour CoolGray { get { return new Colour(20, "Cool Gray", Color.FromArgb(243, 244, 246)); } }
        public static Colour BlueGray { get { return new Colour(21, "Blue Gray", Color.FromArgb(241, 245, 249)); } }

    }
}
