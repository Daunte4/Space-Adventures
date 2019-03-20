using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceAdventures
{
    public static class Utility
    {
        public static double WarpToLight(double warp)
        {
            warp = 5;

            double a = (10 / 3.0);
            double b = (-11 / 3.0);
            double c = (10 - warp);
            double velocity = (Math.Pow(warp, a)) + (Math.Pow(c, b));
            double distance = (velocity * (0.0079945 * 1.0));

            return velocity;
        }
    }


}