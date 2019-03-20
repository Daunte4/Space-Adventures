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
            
            
            //double lightyear = (distance * Planets);

            double Nibiru = (distance * 500);
            double Risa = (distance * 79);
            double Vulcan = (distance * 16);
            double AlphaCentouri = (distance * 4.37);

            double year = (Nibiru / 365);


            double EarthLocation = 0;
            double AlphaCenturiaLocation = 3.09006;
            double VulcanLocation = 11.31371;
            double RisaLocation = 55.86144;
            double NibiruLocation = 353.55339;






            double Days_Total = distance * (Math.Sqrt(Math.Pow((AlphaCenturiaLocation - EarthLocation), 2) + Math.Pow((AlphaCenturiaLocation - EarthLocation), 2)));
            double Days_Total1 = distance * (Math.Sqrt(Math.Pow((VulcanLocation - EarthLocation), 2) + Math.Pow((VulcanLocation - EarthLocation), 2)));
            double Days_Total2 = distance * (Math.Sqrt(Math.Pow((RisaLocation - EarthLocation), 2) + Math.Pow((RisaLocation - EarthLocation), 2)));
            double Days_Total3 = distance * (Math.Sqrt(Math.Pow((NibiruLocation - EarthLocation), 2) + Math.Pow((NibiruLocation - EarthLocation), 2)));
            double Days_Total4 = distance * (Math.Sqrt(Math.Pow((RisaLocation - VulcanLocation), 2) + Math.Pow((RisaLocation - VulcanLocation), 2)));

            /*
            Console.WriteLine($"\nWarp speed equals {velocity:F4} m/s.");
            Console.WriteLine($"\nTravling 1 light year will take roughly {distance:F2} days.");
            Console.WriteLine($"\nTravling to Nibiru will take roughly {Nibiru:F2} days or {year:F1} years.");
            Console.WriteLine($"\nTravling to Risa  will take roughly {Risa:F2} days.");
            Console.WriteLine($"\nTravling to Vulcan  will take roughly {Vulcan:F2} days.");
            Console.WriteLine($"\nTravling to Alpha Centouri 3 will take roughly {AlphaCentouri:F2} days.");
            

            Console.WriteLine($"\n\n{Days_Total:F2} Days");
            Console.WriteLine($"\n\n{Days_Total1:F2} Days");
            Console.WriteLine($"\n\n{Days_Total2:F2} Days");
            Console.WriteLine($"\n\n{Days_Total3:F2} Days");
            Console.WriteLine($"\n\n{Days_Total4:F2} Days");
            */


            return distance;
        }
    }
}