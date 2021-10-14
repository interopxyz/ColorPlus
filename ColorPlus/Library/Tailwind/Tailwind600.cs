
using System.Drawing;

namespace ColorPlus.Tailwind
{
    public struct Tailwind600
    {
        public static readonly Tailwind600 Empty;
        public static Colour Red { get { return new Colour(0, "Red", Color.FromArgb(220, 38, 38)); } }
        public static Colour Orange { get { return new Colour(1, "Orange", Color.FromArgb(234, 88, 12)); } }
        public static Colour Amber { get { return new Colour(2, "Amber", Color.FromArgb(217, 119, 6)); } }
        public static Colour Yellow { get { return new Colour(3, "Yellow", Color.FromArgb(202, 138, 4)); } }
        public static Colour Lime { get { return new Colour(4, "Lime", Color.FromArgb(101, 163, 13)); } }
        public static Colour Green { get { return new Colour(5, "Green", Color.FromArgb(22, 163, 74)); } }
        public static Colour Emerald { get { return new Colour(6, "Emerald", Color.FromArgb(5, 150, 105)); } }
        public static Colour Teal { get { return new Colour(7, "Teal", Color.FromArgb(13, 148, 136)); } }
        public static Colour Cyan { get { return new Colour(8, "Cyan", Color.FromArgb(8, 145, 178)); } }
        public static Colour LightBlue { get { return new Colour(9, "Light Blue", Color.FromArgb(2, 132, 199)); } }
        public static Colour Blue { get { return new Colour(10, "Blue", Color.FromArgb(37, 99, 235)); } }
        public static Colour Indigo { get { return new Colour(11, "Indigo", Color.FromArgb(79, 70, 229)); } }
        public static Colour Violet { get { return new Colour(12, "Violet", Color.FromArgb(124, 58, 237)); } }
        public static Colour Purple { get { return new Colour(13, "Purple", Color.FromArgb(147, 51, 234)); } }
        public static Colour Fuchsia { get { return new Colour(14, "Fuchsia", Color.FromArgb(192, 38, 211)); } }
        public static Colour Pink { get { return new Colour(15, "Pink", Color.FromArgb(219, 39, 119)); } }
        public static Colour Rose { get { return new Colour(16, "Rose", Color.FromArgb(225, 29, 72)); } }
        public static Colour WarmGray { get { return new Colour(17, "Warm Gray", Color.FromArgb(87, 83, 78)); } }
        public static Colour TrueGray { get { return new Colour(18, "True Gray", Color.FromArgb(82, 82, 82)); } }
        public static Colour Gray { get { return new Colour(19, "Gray", Color.FromArgb(82, 82, 91)); } }
        public static Colour CoolGray { get { return new Colour(20, "Cool Gray", Color.FromArgb(75, 85, 99)); } }
        public static Colour BlueGray { get { return new Colour(21, "Blue Gray", Color.FromArgb(71, 85, 105)); } }

    }
}
