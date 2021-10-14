
using System.Drawing;

namespace ColorPlus.D3.Categorical
{
    public struct Accent
    {
        public static readonly Accent Empty;
        public static Colour Accent010 { get { return new Colour(10, "Accent010", Color.FromArgb(127, 201, 127)); } }
        public static Colour Accent020 { get { return new Colour(11, "Accent020", Color.FromArgb(190, 174, 212)); } }
        public static Colour Accent030 { get { return new Colour(12, "Accent030", Color.FromArgb(253, 192, 134)); } }
        public static Colour Accent040 { get { return new Colour(13, "Accent040", Color.FromArgb(255, 255, 153)); } }
        public static Colour Accent050 { get { return new Colour(14, "Accent050", Color.FromArgb(56, 108, 176)); } }
        public static Colour Accent060 { get { return new Colour(15, "Accent060", Color.FromArgb(240, 2, 127)); } }
        public static Colour Accent070 { get { return new Colour(16, "Accent070", Color.FromArgb(191, 91, 23)); } }
        public static Colour Accent080 { get { return new Colour(17, "Accent080", Color.FromArgb(102, 102, 102)); } }

    }
}