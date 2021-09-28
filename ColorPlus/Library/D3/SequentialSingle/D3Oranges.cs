
using System.Drawing;

namespace ColorPlus.D3.SequentialSingle
{
    public struct Oranges
    {
        public static readonly Oranges Empty;
        public static Colour Oranges000 { get { return new Colour(15, "Oranges000", Color.FromArgb(255, 245, 235)); } }
        public static Colour Oranges025 { get { return new Colour(16, "Oranges025", Color.FromArgb(253, 206, 160)); } }
        public static Colour Oranges050 { get { return new Colour(17, "Oranges050", Color.FromArgb(251, 140, 60)); } }
        public static Colour Oranges075 { get { return new Colour(18, "Oranges075", Color.FromArgb(213, 75, 4)); } }
        public static Colour Oranges100 { get { return new Colour(19, "Oranges100", Color.FromArgb(127, 39, 4)); } }

    }
}