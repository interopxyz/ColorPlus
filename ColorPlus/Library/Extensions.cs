using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ColorPlus
{
    public static class Extensions
    {


        public static Color AverageColors(this List<Color> colors)
        {
            int C = colors.Count;
            if (C > 0)
            {
                double A = 0;
                double R = 0;
                double G = 0;
                double B = 0;

                foreach(Color color in colors)
                {
                    A += color.A;
                    R += color.R;
                    G += color.G;
                    B += color.B;
                }
                A /= C;
                R /= C;
                G /= C;
                B /= C;

                return Color.FromArgb((int)A, (int)R, (int)G, (int)B);
            }
            else
            {
                return Color.Empty;
            }

        }

        public static Color Tween(this Color source, Color target,double parameter)
        {
            double A = source.A + (target.A - source.A) * parameter;
            double R = source.R + (target.R - source.R) * parameter;
            double G = source.G + (target.G - source.G) * parameter;
            double B = source.B + (target.B - source.B) * parameter;

            return Color.FromArgb((int)A, (int)R, (int)G, (int)B);
        }

        public static Color Blend(this Color source, Color target, double parameter)
        {
            double param = (1.0+Math.Cos(Math.PI+parameter * Math.PI))/2.0;
            double A = source.A + (target.A - source.A) * param;
            double R = source.R + (target.R - source.R) * param;
            double G = source.G + (target.G - source.G) * param;
            double B = source.B + (target.B - source.B) * param;

            return Color.FromArgb((int)A, (int)R, (int)G, (int)B);
        }

        public static Color Invert(this Color input)
        {
            return Color.FromArgb(input.A, 255 - input.R, 255 - input.G, 255 - input.B);
        }


    }
}
