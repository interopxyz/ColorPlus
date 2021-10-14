
using System.Drawing;

namespace ColorPlus.D3.SequentialSingle
{
    public struct Blues
    {
        public static readonly Blues Empty;
        public static Colour Blues000 { get { return new Colour(0, "Blues000", Color.FromArgb(247, 251, 255)); } }
        public static Colour Blues025 { get { return new Colour(1, "Blues025", Color.FromArgb(195, 219, 238)); } }
        public static Colour Blues050 { get { return new Colour(2, "Blues050", Color.FromArgb(108, 174, 213)); } }
        public static Colour Blues075 { get { return new Colour(3, "Blues075", Color.FromArgb(35, 113, 180)); } }
        public static Colour Blues100 { get { return new Colour(4, "Blues100", Color.FromArgb(8, 48, 107)); } }

    }
}