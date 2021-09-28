
using System.Drawing;

namespace ColorPlus.D3.SequentialMultiple
{
    public struct YIOrBr
    {
        public static readonly YIOrBr Empty;
        public static Colour YlOrBr000 { get { return new Colour(50, "YlOrBr000", Color.FromArgb(255, 255, 229)); } }
        public static Colour YlOrBr025 { get { return new Colour(51, "YlOrBr025", Color.FromArgb(254, 225, 141)); } }
        public static Colour YlOrBr050 { get { return new Colour(52, "YlOrBr050", Color.FromArgb(251, 153, 43)); } }
        public static Colour YlOrBr075 { get { return new Colour(53, "YlOrBr075", Color.FromArgb(201, 78, 5)); } }
        public static Colour YlOrBr100 { get { return new Colour(54, "YlOrBr100", Color.FromArgb(102, 37, 6)); } }

    }
}