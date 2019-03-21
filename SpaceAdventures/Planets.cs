using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceAdventures
{
    public static class Planet
    {

        //This a switch statment that talks about Planet information
        public static void PlanetInfomaton()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nSelect below to get infomaton about each Planet.");
            Console.WriteLine("\n1.To travel to a planet " + " 2.Alpha Centouri: 3 " + " 3.Vulcan " + " 4.Risa " + " 5.Nibiru " + " 6.Earth.");
            Console.ForegroundColor = ConsoleColor.Green;
            int select = int.Parse(Console.ReadLine());
            switch (select)
            {
                case 6:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\nEarth is home and their currency is Money, Water, Fuel, Animals, and plant seeds");
                    Console.ResetColor();
                    PlanetInfomaton();
                    break;

                case 2:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"\nAlpha Centouri: 3 is 4.37 light-years from the Earth and their currency is Money, Water, Fuel, Animals, and plant seeds." +
                        $"\nTravling to Alpha Centouri 3 will take roughly 7.47 days.");
                    Console.ResetColor();
                    PlanetInfomaton();
                    break;

                case 3:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\nVulcan is 16 light-years from Earth and their currency is Money, Water, Fuel, Animals, and plant seeds." +
                        "\nTravling to Vulcan  will take roughly 27.34 days.");
                    Console.ResetColor();
                    PlanetInfomaton();
                    break;


                case 4:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\nRisa is 79 light-years from Earth and their currency is Money, Water, Fuel, Animals, and plant seeds." +
                        "\nTravling to Risa  will take roughly 135.00 days");
                    Console.ResetColor();
                    PlanetInfomaton();
                    break;

                case 5:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\nLiberia is 500 light-years from Earth and their currency is Money, Water, Fuel, Animals, and plant seeds." +
                        "\nTravling to Liberia will take roughly 854.41 days or 2.3 years.");
                    Console.ResetColor();
                    PlanetInfomaton();
                    break;
                case 1:
                    //TravelToAPlanet();

                    break;

            }
            Console.ResetColor();
        }

    }
}

