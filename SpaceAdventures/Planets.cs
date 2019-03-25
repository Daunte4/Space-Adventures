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
                    Console.WriteLine("\nEarth is home and their currency is Spices, and Jewels. Spices is what people sell on this planet"+
                        " the aniamls people use on their land to reproduce , they kill and cook the animals. " + "\nSpices are expensive because everyone on the planet has a job that can afford these currencys" +
                        "and is very important to the people on this planet because they value taste from the spices" + "\nJewel affordable is considered money on this planet");
                    Console.ResetColor();
                    PlanetInfomaton();
                    break;

                case 2:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"\nAlpha Centouri: 3 is 4.37 light-years from the Earth and their currency is Spices, and seeds." +
                       "\nSeeds are affordable and used for the crops they plant in the ground to create their food source" +
                       "\nSpices are cheap and it help make the crops they grow to eat as food taste better, the people value their food"+ 
                       "$\nTravling to Alpha Centouri 3 will take roughly 7.47 days.");
                    Console.ResetColor();
                    PlanetInfomaton();
                    break;

                case 3:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\nVulcan is 16 light-years from Earth and their currency is  Rice, Shoes, Seeds." +
                        " Rice is cheap and is worth the trading value for money" + "\nShoes are affordable and is very important on this plant due to the rocky terrain" +
                        " its very difficult walking barefoot on the terrain on this planet" +
                        "\nSeeds are affordable but used create crops when you plant them in the ground on your land" +
                        "\nTravling to Vulcan  will take roughly 27.34 days.");
                    Console.ResetColor();
                    PlanetInfomaton();
                    break;


                case 4:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\nRisa is 79 light-years from Earth and their currency is  Jewels, Shoes, Rice." +
                        "\nJewels are expensive to trade for but known as money on this planet, you could buy or trade with it" +
                        "\nShoes are affordable and needed for the more wet terrain to prevent affections in your feet" +
                        "\nRice is is cheap and is used to feed their food source animals they have on their land" +
                        "\nTravling to Risa  will take roughly 135.00 days");
                    Console.ResetColor();
                    PlanetInfomaton();
                    break;

                case 5:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\nNibiru is 500 light-years from Earth and their currency is Shoes, Jewels, Seeds." +
                        "\nShoes are less expensive on this planet because their not needed for the terrain on this planet" +
                        "\nJewels are expensive here because their used to melt down and create ships. " +
                        "\nSeeds are used to trade for the fuel for the ship or used to plant your crops" +
                        "\nTravling to nibiru will take roughly 854.41 days or 2.3 years.");
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

