
using System.Drawing;

namespace ColorPlus.D3.SequentialSpectrum
{
    public struct Cividis
    {
        public static readonly Cividis Empty;
        public static Colour Cividis000 { get { return new Colour(0, "Cividis000", Color.FromArgb(0, 32, 81)); } }
        public static Colour Cividis016 { get { return new Colour(1, "Cividis016", Color.FromArgb(30, 62, 110)); } }
        public static Colour Cividis033 { get { return new Colour(2, "Cividis033", Color.FromArgb(87, 92, 110)); } }
        public static Colour Cividis050 { get { return new Colour(3, "Cividis050", Color.FromArgb(128, 124, 117)); } }
        public static Colour Cividis066 { get { return new Colour(4, "Cividis066", Color.FromArgb(164, 157, 120)); } }
        public static Colour Cividis083 { get { return new Colour(5, "Cividis083", Color.FromArgb(214, 194, 99)); } }
        public static Colour Cividis100 { get { return new Colour(6, "Cividis100", Color.FromArgb(253, 234, 69)); } }

    }
}