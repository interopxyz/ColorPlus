
using System.Drawing;

namespace ColorPlus.D3.SequentialMultiple
{
    public struct PuBu
    {
        public static readonly PuBu Empty;
        public static Colour PuBu000 { get { return new Colour(25, "PuBu000", Color.FromArgb(255, 247, 251)); } }
        public static Colour PuBu025 { get { return new Colour(26, "PuBu025", Color.FromArgb(205, 209, 230)); } }
        public static Colour PuBu050 { get { return new Colour(27, "PuBu050", Color.FromArgb(113, 168, 206)); } }
        public static Colour PuBu075 { get { return new Colour(28, "PuBu075", Color.FromArgb(13, 114, 173)); } }
        public static Colour PuBu100 { get { return new Colour(29, "PuBu100", Color.FromArgb(2, 56, 88)); } }

    }
}