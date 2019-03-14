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

        //This a switch statment that talks about Planet information
        public void PlanetInfomaton()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nSelect below to get infomaton about each Planet.");
            Console.WriteLine("\n1.Earth " + " 2.Alpha Centouri: 3 " + " 3.Vulcan " + " 4.Risa " + " 5.Nibiru " + " 6.To travel to a planet.");
            Console.ForegroundColor = ConsoleColor.Green;
            int select = int.Parse(Console.ReadLine());
            switch (select)
            {
                case 1:
                    Console.Clear();
                    //Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nEarth is home and their currency is Money");
                    Console.ResetColor();
                    PlanetInfomaton();
                    break;

                case 2:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"\nAlpha Centouri: 3 is 4.37 light-years from the Earth and their currency is Jewlery." +
                        $"\nTravling to Alpha Centouri 3 will take roughly 7.47 days.");
                    Console.ResetColor();
                    PlanetInfomaton();
                    break;

                case 3:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nVulcan is 16 light-years from Earth and their currency is Water." +
                        "\nTravling to Vulcan  will take roughly 27.34 days.");
                    Console.ResetColor();
                    PlanetInfomaton();
                    break;


                case 4:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nRisa is 79 light-years from Earth and their currency is Fuel." +
                        "\nTravling to Risa  will take roughly 135.00 days");
                    Console.ResetColor();
                    PlanetInfomaton();
                    break;

                case 5:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nNibiru is 500 light-years from Earth and their currency is Animals." +
                        "\nTravling to Nibiru will take roughly 854.41 days or 2.3 years.");
                    Console.ResetColor();
                    PlanetInfomaton();
                    break;
                case 6:
                    TravelToAPlanet();
                    break;

            }
            Console.ResetColor();

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
/*
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
    */
    }
}

