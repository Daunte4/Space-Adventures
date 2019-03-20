using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceAdventures
{
    public class Planets
    {

        public void Run()
        {
            Console.Clear();
            PlanetInfomaton();
            //TravelToAPlanet();
        }
        public void StartLocation()
        {
            Console.WriteLine("\nYou are starting at the planet earth.\n");
            Console.Read();
        }
        public void ShipName()
        {
            Console.WriteLine("\nYour ship is called: The Lady Grey");
            Console.Read();
        }
        public void ShipStatus()
        {
            Console.WriteLine("\nYour ship that you started with can only travel 500 light years.\n");
            Console.Read();
        }


        public void ShipLocation()
        {
            string name = "";
            //Console.Clear();
            bool check = false;
            while (check == false)

            {
                Console.WriteLine("\nSelect from the options below.\n" + "1. Disembarking " + " 2. Plotting a course");
                name = Console.ReadLine();
                switch (name)

                {
                    case "1":
                        Console.WriteLine("Disembarking...");
                        Console.ReadLine();
                        break;
                    case "2":
                        Console.WriteLine("Plotting a course...");
                        Console.ReadLine();
                        break;
                }
            }


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
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\nEarth is home and their currency is Money");
                    Console.ResetColor();
                    PlanetInfomaton();
                    break;

                case 2:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"\nAlpha Centouri: 3 is 4.37 light-years from the Earth and their currency is Jewlery." +
                        $"\nTravling to Alpha Centouri 3 will take roughly 7.47 days.");
                    Console.ResetColor();
                    PlanetInfomaton();
                    break;

                case 3:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\nVulcan is 16 light-years from Earth and their currency is Water." +
                        "\nTravling to Vulcan  will take roughly 27.34 days.");
                    Console.ResetColor();
                    PlanetInfomaton();
                    break;


                case 4:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\nRisa is 79 light-years from Earth and their currency is Fuel." +
                        "\nTravling to Risa  will take roughly 135.00 days");
                    Console.ResetColor();
                    PlanetInfomaton();
                    break;

                case 5:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\nLiberia is 500 light-years from Earth and their currency is Animals." +
                        "\nTravling to Liberia will take roughly 854.41 days or 2.3 years.");
                    Console.ResetColor();
                    PlanetInfomaton();
                    break;
                case 6:
                    //TravelToAPlanet();
                    break;

            }
            Console.ResetColor();

            // Console.WriteLine("The equation for warp speed is v(W) = W((10/3)+u(W−9)∙A∙(−loge(10−W))n ");
            //Console.WriteLine("Were do you want to travel to?");
        }

        public void App()
        {
            var beer = new Item("Space Beer", 1.2M);
            var honey = new Item("Space Honey", 3.4M);
            var illegalArms = new Item("Illegal Arms", 1000.88M);

            locations.Add(
                new LocationXYdistance("Earth",
                             "A pale blue dot, even at your close distance. The birthplace of mankind, now deserted.",
                             0, 0,
                             new List<Item>() { beer, illegalArms }));

            locations.Add(
                new LocationXYdistance("Alpha Centauri 3",
                             "The new home world of the human race, such as it is.",
                             3.09006, 3.09006,
                             new List<Item>() { honey },
                             0.9M));

            locations.Add(
                new LocationXYdistance("Vulcan planet",
                             "One of the best places to live ever",
                             11.31371, 11.31371,
                             new List<Item>() { honey, illegalArms, beer },
                             (decimal)11.31371));
            locations.Add(
             new LocationXYdistance("Risa planet",
                          "Don stay to long or you will be killed",
                          55.86144, 55.86144,
                          new List<Item>() { honey, illegalArms, beer },
                          (decimal)11.31371));

            locations.Add(
             new LocationXYdistance("Nibiru planet",
                          "Maybe you can find your mom in this place.",
                          353.55339, 353.55339,
                          new List<Item>() { honey, illegalArms, beer },
                          (decimal)11.31371));

            // hero = new Player(LocationXYdistance[0]);
        }

        /*

        public void TravelToAPlanet()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear();
            Console.WriteLine("\nWhat planet do you want to travel to trade with?");
            Console.WriteLine("\n1.Earth " + " 2.Alpha Centouri: 3 " + " 3.Vulcan " + " 4.Risa " + " 5.Nibiru " + " 6.Return to planet Infomation.");
            int select = int.Parse(Console.ReadLine());
            switch (select)
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Earth is home and their currency is Money");
                    Console.ResetColor();
                    break;

                case 2:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Nibiru is 1 light-years from Earth and their currency is clothes.");
                    Console.ResetColor();
                    break;

                case 3:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Alpha Centouri: 3 is 4.37 light-years from the Earth and their currency is Jewlery.");
                    Console.ResetColor();
                    break;

                case 4:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Vulcan is 16 light-years from Earth and their currency is Water.");
                    Console.ResetColor();
                    break;

                case 5:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Risa is 79 light-years from Earth and their currency is Fuel.");
                    Console.ResetColor();
                    break;

                case 6:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    PlanetInfomaton();
                    break;
                case 7:
                    break;

            }

        }
        */

        /*class Earth
        {
            double distance = 0 + 0L;
            //distance from Earth(0) = Earth(0 days)
            
            
           
        }

        class AlphaCentouri
        {
            double distance = 0 + 4.4;
            //distance from Earth(0) = AlphaCentouri(1551 days)
        }

        class Vulcan
        {
            double distance = 0 + 16L;
            //distance from Earth(0) = Vulcan(5840 days)

        }

        class Risa
        {
            double distance = 0 + 79L;
            //distance from Earth(0) =  Risa(28835 days)
        }

        class Nibiru
        {
            double distance = 0 + 1L;           
            //distance from Earth(0) = Nibiru(365 days)
        }

        class Liberia
        {
            double distance = 0 + 500L;
            //distance from Earth(0) = Liberia(182500 days)
        }
        */

    }
}

