using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceAdventures
{
    class XY_and_Location
    {
        public void Run()
        {
            //WarpEquation();
            // Coords;
        }
        public double WarpEquation()
        {
            double warp = 5;
            double a = (10 / 3.0);
            double b = (-11 / 3.0);
            double c = (10 - warp);
            double velocity = (Math.Pow(warp, a)) + (Math.Pow(c, b));


            double distance = (velocity * (0.0079945 * 1.0));

            double Nibiru = (distance * 500);
            double Risa = (distance * 79);
            double Vulcan = (distance * 16);
            double AlphaCentouri = (distance * 4.37);

            double year = (Nibiru / 365);

            Console.WriteLine($"\nWarp speed equals {velocity:F4} m/s.");
            Console.WriteLine($"\nTravling 1 light year will take roughly {distance:F2} days.");
            Console.WriteLine($"\nTravling to Nibiru will take roughly {Nibiru:F2} days or {year:F1} years.");
            Console.WriteLine($"\nTravling to Risa  will take roughly {Risa:F2} days.");
            Console.WriteLine($"\nTravling to Vulcan  will take roughly {Vulcan:F2} days.");
            Console.WriteLine($"\nTravling to Alpha Centouri 3 will take roughly {AlphaCentouri:F2} days.");
            return velocity;
        }
        /*
        public static void PythagorasTheorem()
        {
            double h, p, b, sqh;

            Console.WriteLine("Please Enter the Value of Perpendicular");

            p = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Please Enter the Value of Base");

            b = Convert.ToDouble(Console.ReadLine());


            sqh = p * p + b * b;


            h = Math.Sqrt(sqh);

            Console.WriteLine("Hypotenius is {0}", h);

        }
        */
        internal struct Coords
        {
            int x;
            int y;
            public Coords(int x, int y)
            {
                this.x = x;
                this.y = y;
            }

            public static double DistanceBetween(Coords a, Coords b)
            {
                var xSqrtDist = Math.Pow(a.x - b.x, 2);
                var ySqrtDist = Math.Pow(a.y - b.y, 2);

                return Math.Sqrt(xSqrtDist + ySqrtDist);
            }
        }
      
    }
}
/*
earth location(0, 0)
Alpha Centuria(3.09006,3.09006)
Vulcan(11.31371,11.31371)
Risa(55.86144, 55.86144)
Nibiru(353.55339, 353.55339)
*/
