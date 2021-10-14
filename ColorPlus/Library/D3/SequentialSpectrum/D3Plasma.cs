
using System.Drawing;

namespace ColorPlus.D3.SequentialSpectrum
{
    public struct Plasma
    {
        public static readonly Plasma Empty;
        public static Colour Plasma000 { get { return new Colour(28, "Plasma000", Color.FromArgb(13, 8, 135)); } }
        public static Colour Plasma016 { get { return new Colour(29, "Plasma016", Color.FromArgb(92, 1, 166)); } }
        public static Colour Plasma033 { get { return new Colour(30, "Plasma033", Color.FromArgb(156, 23, 158)); } }
        public static Colour Plasma050 { get { return new Colour(31, "Plasma050", Color.FromArgb(204, 71, 120)); } }
        public static Colour Plasma066 { get { return new Colour(32, "Plasma066", Color.FromArgb(237, 121, 83)); } }
        public static Colour Plasma083 { get { return new Colour(33, "Plasma083", Color.FromArgb(253, 180, 47)); } }
        public static Colour Plasma100 { get { return new Colour(34, "Plasma100", Color.FromArgb(240, 249, 33)); } }

    }
}