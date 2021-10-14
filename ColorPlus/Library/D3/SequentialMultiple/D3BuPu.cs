
using System.Drawing;

namespace ColorPlus.D3.SequentialMultiple
{
    public struct BuPu
    {
        public static readonly BuPu Empty;
        public static Colour BuPu000 { get { return new Colour(5, "BuPu000", Color.FromArgb(247, 252, 253)); } }
        public static Colour BuPu025 { get { return new Colour(6, "BuPu025", Color.FromArgb(191, 211, 230)); } }
        public static Colour BuPu050 { get { return new Colour(7, "BuPu050", Color.FromArgb(143, 149, 198)); } }
        public static Colour BuPu075 { get { return new Colour(8, "BuPu075", Color.FromArgb(136, 64, 155)); } }
        public static Colour BuPu100 { get { return new Colour(9, "BuPu100", Color.FromArgb(77, 0, 75)); } }

    }
}