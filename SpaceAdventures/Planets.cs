using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceAdventures
{
    class Planets
    {
        public void Run()
        {
            WarpEquation();
            PlanetInfomaton();
            TravelToAPlanet();
        }
        //This a switch statment that talks about Planet information
        public void PlanetInfomaton()
        {
            Console.WriteLine("\nSelect below to get infomaton about each Planet.");
            Console.WriteLine("\n1.Earth " + " 2.Alpha Centouri: 3 " + " 3.Vulcan " + " 4.Risa " + " 5.Nibiru " + " 6.To travel to a planet.");

            int select = int.Parse(Console.ReadLine());
            switch (select)
            {
                case 1:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nEarth is home and their currency is Money");
                    Console.ResetColor();
                    PlanetInfomaton();
                    break;

                case 2:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nAlpha Centouri: 3 is 4.37 light-years from the Earth and their currency is Jewlery.");
                    Console.ResetColor();
                    PlanetInfomaton();
                    break;

                case 3:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nVulcan is 16 light-years from Earth and their currency is Water.");
                    Console.ResetColor();
                    PlanetInfomaton();
                    break;


                case 4:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nRisa is 79 light-years from Earth and their currency is Fuel.");
                    Console.ResetColor();
                    PlanetInfomaton();
                    break;

                case 5:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nNibiru is 500 light-years from Earth and their currency is Animals");
                    Console.ResetColor();
                    PlanetInfomaton();
                    break;
                case 6:
                    TravelToAPlanet();
                    break;

            }

            // Console.WriteLine("The equation for warp speed is v(W) = W((10/3)+u(W−9)∙A∙(−loge(10−W))n ");
            //Console.WriteLine("Were do you want to travel to?");
        }

        public void TravelToAPlanet()
        {
            Console.Clear();
            Console.WriteLine("\nWhat planet do you want to travel to trade with?");
            Console.WriteLine("\n1.Earth " + " 2.Alpha Centouri: 3 " + " 3.Vulcan " + " 4.Risa " + " 5.Nibiru " + " 6.Return to planet Infomation.");
            int select = int.Parse(Console.ReadLine());
            switch (select)
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Earth is home and their currency is Money");
                    Console.ResetColor();
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Alpha Centouri: 3 is 4.37 light-years from the Earth and their currency is Jewlery.");
                    Console.ResetColor();
                    break;

                case 3:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Vulcan is 16 light-years from Earth and their currency is Water.");
                    Console.ResetColor();
                    break;

                case 4:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Vulcan is 79 light-years from Earth and their currency is Fuel.");
                    Console.ResetColor();
                    break;

                case 5:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Vulcan is 500 light-years from Earth and their currency is Animals");
                    break;
                case 6:
                    Console.Clear();
                    PlanetInfomaton();
                    break;

            }

        }


        public double WarpEquation()
        {
            double warp = 5;
            double a = (10 / 3.0);
            double b = (-11 / 3.0);
            double c = (10 - warp);
            double velocity = (Math.Pow(warp, a)) + (Math.Pow(c, b));
            Console.WriteLine($"\nWarp speed equals {velocity} m/s.");
            return velocity;
            //1 light year eqauk
        }


        private static void PythagorasTheorem()
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
        public class Earth
        {

        }
        public class AlphaCentouri
        {
        }
        public class Vulcan
        {

        }
        public class Risa
        {


        }
        public class Nibiru
        {

        }
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

