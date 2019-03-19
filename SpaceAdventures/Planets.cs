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
            PlanetInfomaton();
            TravelToAPlanet();
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
                    Console.WriteLine($"\nNibiru is 1 light-years from earth and their currency is Clothes." +
                        $"\nTraveling to Nibiru is 1 light year away and will take 365 days.");
                    Console.ResetColor();
                    PlanetInfomaton();
                    break;

                case 3:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"\nAlpha Centouri: 3 is 4.37 light-years from the Earth and their currency is Jewlery." +
                        $"\nTravling to Alpha Centouri 3 will take roughly 7.47 days.");
                    Console.ResetColor();
                    PlanetInfomaton();
                    break;

                case 4:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nVulcan is 16 light-years from Earth and their currency is Water." +
                        "\nTravling to Vulcan  will take roughly 27.34 days.");
                    Console.ResetColor();
                    PlanetInfomaton();
                    break;


                case 5:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nRisa is 79 light-years from Earth and their currency is Fuel." +
                        "\nTravling to Risa  will take roughly 135.00 days");
                    Console.ResetColor();
                    PlanetInfomaton();
                    break;

                case 6:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nLiberia is 500 light-years from Earth and their currency is Animals." +
                        "\nTravling to Liberia will take roughly 854.41 days or 2.3 years.");
                    Console.ResetColor();
                    PlanetInfomaton();
                    break;
                case 7:
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
                    Console.WriteLine("Nibiru is 1 light-years from Earth and their currency is clothes.");
                    Console.ResetColor();
                    break;

                case 3:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Alpha Centouri: 3 is 4.37 light-years from the Earth and their currency is Jewlery.");
                    Console.ResetColor();
                    break;

                case 4:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Vulcan is 16 light-years from Earth and their currency is Water.");
                    Console.ResetColor();
                    break;

                case 5:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Risa is 79 light-years from Earth and their currency is Fuel.");
                    Console.ResetColor();
                    break;

                case 6:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Liberia is 500 light-years from Earth and their currency is Animals");
                    break;
                case 7:
                    Console.Clear();
                    PlanetInfomaton();
                    break;

            }

        }

        
        public class Earth
        {
            double distance = 0 + 0L;
            //distance from Earth(0) = Earth(0 days)
            
            
           
        }

        public class AlphaCentouri
        {
            double distance = 0 + 4.4;
            //distance from Earth(0) = AlphaCentouri(1551 days)
        }

        public class Vulcan
        {
            double distance = 0 + 16L;
            //distance from Earth(0) = Vulcan(5840 days)

        }

        public class Risa
        {
            double distance = 0 + 79L;
            //distance from Earth(0) =  Risa(28835 days)
        }

        public class Nibiru
        {
            double distance = 0 + 1L;
            //distance from Earth(0) = Nibiru(365 days)
        }

        public class Liberia
        {
            double distance = 0 + 500L;
            //distance from Earth(0) = Liberia(182500 days)
        }
    
    }
}

