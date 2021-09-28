
using System.Drawing;

namespace ColorPlus.D3.SequentialSpectrum
{
    public struct Viridis
    {
        public static readonly Viridis Empty;
        public static Colour Viridis000 { get { return new Colour(7, "Viridis000", Color.FromArgb(68, 1, 84)); } }
        public static Colour Viridis016 { get { return new Colour(8, "Viridis016", Color.FromArgb(68, 57, 131)); } }
        public static Colour Viridis033 { get { return new Colour(9, "Viridis033", Color.FromArgb(49, 104, 142)); } }
        public static Colour Viridis050 { get { return new Colour(10, "Viridis050", Color.FromArgb(33, 145, 140)); } }
        public static Colour Viridis066 { get { return new Colour(11, "Viridis066", Color.FromArgb(53, 183, 121)); } }
        public static Colour Viridis083 { get { return new Colour(12, "Viridis083", Color.FromArgb(144, 215, 67)); } }
        public static Colour Viridis100 { get { return new Colour(13, "Viridis100", Color.FromArgb(253, 231, 37)); } }

    }
}