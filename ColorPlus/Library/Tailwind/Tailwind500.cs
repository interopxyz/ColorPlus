
using System.Drawing;

namespace ColorPlus.Tailwind
{
    public struct Tailwind500
    {
        public static readonly Tailwind500 Empty;
        public static Colour Red { get { return new Colour(0, "Red", Color.FromArgb(239, 68, 68)); } }
        public static Colour Orange { get { return new Colour(1, "Orange", Color.FromArgb(249, 115, 22)); } }
        public static Colour Amber { get { return new Colour(2, "Amber", Color.FromArgb(245, 158, 11)); } }
        public static Colour Yellow { get { return new Colour(3, "Yellow", Color.FromArgb(234, 179, 8)); } }
        public static Colour Lime { get { return new Colour(4, "Lime", Color.FromArgb(132, 204, 22)); } }
        public static Colour Green { get { return new Colour(5, "Green", Color.FromArgb(34, 197, 94)); } }
        public static Colour Emerald { get { return new Colour(6, "Emerald", Color.FromArgb(16, 185, 129)); } }
        public static Colour Teal { get { return new Colour(7, "Teal", Color.FromArgb(20, 184, 166)); } }
        public static Colour Cyan { get { return new Colour(8, "Cyan", Color.FromArgb(6, 182, 212)); } }
        public static Colour LightBlue { get { return new Colour(9, "Light Blue", Color.FromArgb(14, 165, 233)); } }
        public static Colour Blue { get { return new Colour(10, "Blue", Color.FromArgb(59, 130, 246)); } }
        public static Colour Indigo { get { return new Colour(11, "Indigo", Color.FromArgb(99, 102, 241)); } }
        public static Colour Violet { get { return new Colour(12, "Violet", Color.FromArgb(139, 92, 246)); } }
        public static Colour Purple { get { return new Colour(13, "Purple", Color.FromArgb(168, 85, 247)); } }
        public static Colour Fuchsia { get { return new Colour(14, "Fuchsia", Color.FromArgb(217, 70, 239)); } }
        public static Colour Pink { get { return new Colour(15, "Pink", Color.FromArgb(236, 72, 153)); } }
        public static Colour Rose { get { return new Colour(16, "Rose", Color.FromArgb(244, 63, 94)); } }
        public static Colour WarmGray { get { return new Colour(17, "Warm Gray", Color.FromArgb(120, 113, 108)); } }
        public static Colour TrueGray { get { return new Colour(18, "True Gray", Color.FromArgb(115, 115, 115)); } }
        public static Colour Gray { get { return new Colour(19, "Gray", Color.FromArgb(113, 113, 122)); } }
        public static Colour CoolGray { get { return new Colour(20, "Cool Gray", Color.FromArgb(107, 114, 128)); } }
        public static Colour BlueGray { get { return new Colour(21, "Blue Gray", Color.FromArgb(100, 116, 139)); } }

    }
}
