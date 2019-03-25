using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceAdventures
{
   public class Main_Class
    {
       
            //this code will help run the program
            public void Run()
            {
                var quitReason = EventLoop();

                Intro.ClosingMessage(quitReason);
            }

            List<Location_Destination> locations = new List<Location_Destination>();

        Characters Traveler;

            public  Main_Class()
            {
                var Seeds = new Item_Cost("One pack of Seeds", 1.2M);
                var Jewels = new Item_Cost("One small bag of Jewels", 3.4M);
                var Spices = new Item_Cost("One pack of Spices", 750M);
                var Rice = new Item_Cost("One pack of Rice", 500M);
                var Shoes = new Item_Cost("One pack of Shoes", 21M);






            //earth
            locations.Add(
                    new Location_Destination("Earth", 0, 0, new List<Item_Cost>() { Spices, Jewels }));

            
            //Alpha Centauri 3
                locations.Add(
                    new Location_Destination("Alpha Centauri 3", 3.09006, 3.09006, new List<Item_Cost>() { Spices, Seeds }, (decimal).5));
            
            //Vulcan
                locations.Add(
                    new Location_Destination("Vulcan", 11.31371, 11.31371, new List<Item_Cost>() { Rice, Shoes, Seeds }, (decimal)1.6));

            //Risa
                locations.Add(
                 new Location_Destination("Risa", 55.86144, 55.86144, new List<Item_Cost>() { Jewels, Shoes, Rice }, (decimal)2.35));


                //Nibiru
                locations.Add(
                 new Location_Destination("Nibiru", 353.55339, 353.55339, new List<Item_Cost>() { Shoes, Jewels, Seeds }, (decimal)11.31371));

                Traveler = new Characters(locations[0]);
            }



            public Quit EventLoop()
            {
                Quit quitReason;

                do
                {
                    Console.Clear();

                //Print the current locationConsole.WriteLine
                Console.WriteLine("=============================================================================================================");
                Console.WriteLine($"Location Destination: {Traveler.location.name}  Current Age: {Traveler.AddedAge:F2} years old    Current Currency: {Traveler.money:F2}");
                Console.WriteLine("=============================================================================================================");
                /* {Traveler.location.name} */
                Travel();
                    // Print a description of that location
                    //  Console.WriteLine(Traveler.location.description);

                    // Provide options to the user re. things they can do
                    Travel();

                    var key = UI.ElicitInput();

                    quitReason = ShouldQuit(HandleInput(key));
                } while (quitReason == Quit.DontQuit);

                return quitReason;
            }

            private Quit HandleInput(ConsoleKey key)
            {
                throw new NotImplementedException();
            }

            public void Travel()
            {

                bool check = false;
                while (check == false)


                    do
                    {
                        Console.Clear();
                    Console.WriteLine("=============================================================================================================");
                    Console.WriteLine($"Location Destination: {Traveler.location.name}  Current Age: {Traveler.AddedAge:F2} years old    Current Currency: {Traveler.money:F2}");
                    Console.WriteLine("=============================================================================================================");
                    Console.WriteLine("\nSelect from the options below.\n" + "\n1.Travel to other locations " + "\n2.Disembark your current location" + "\n3.Return to planet infomation" + "\n4.Quit");
                    Console.Write("\t\tMy option is: ");
                    int choice = int.Parse(Console.ReadLine());
                        switch (choice)

                        {
                            case 1:
                                TravelMenu();
                                break;
                            case 2:
                                Disembark();
                                break;
                            case 3:
                                Planet.PlanetInfomaton();
                                break;
                            default:
                                Console.WriteLine("Invalid Selection");
                                check = false;
                                break;
                        }
                    } while (!check);
            }

        public Quit ShouldQuit(Quit quitReason)

        {

            Quit AgeCheck() => Traveler.AddedAge >= 70 ? Quit.Age : Quit.DontQuit;

            Quit MoneyCheck() => Traveler.money < 0 ? Quit.OutOfMoney : Quit.DontQuit;

            if (quitReason == Quit.DontQuit)
            {
                quitReason = AgeCheck();
            }

            if (quitReason == Quit.DontQuit)

            {
        quitReason = MoneyCheck();

            }
   return quitReason;

        }








        public void Disembark()
            {
                Console.Clear();
            Console.WriteLine("=============================================================================================================");
            Console.WriteLine($"Location Destination: {Traveler.location.name}  Age: {Traveler.AddedAge:F2} years    Credits: {Traveler.money:F2}");
            Console.WriteLine("=============================================================================================================");

            bool check = false;
                while (check == false)


                    do
                    {
                        Console.WriteLine("Select from the options below.\n" + "\n1. Retrun to ship " + "\n2. Buy items that you want" + "\n3. Sale items that you have" + "\n4. Quit");
                        Console.Write("\t\tMy option is: ");
                    int choice = int.Parse(Console.ReadLine());
                        switch (choice)

                        {
                            case 1:
                                Travel();
                                break;
                            case 2:
                                BuyMenu();
                                break;
                            case 3:
                                SellMenu();
                                break;
                            default:
                                Console.WriteLine("Invalid Selection");
                                check = false;
                                break;
                        }
                    } while (!check);
            }



      

        public void SellMenu()
            {
                Console.Clear();

                if (Traveler.inventory.Any())
                {
                    PrintItems(Traveler.inventory);

                    var itemIndex = UI.ElicitInput("Which item would you like to sell: ", 1, Traveler.inventory.Count);
               // Console.Write("Option:");
                    if (!itemIndex.cancelled)
                    {
                        Traveler.SellItem(Traveler.inventory[itemIndex.input - 1]);
                    }
                }
                else
                {
                    Console.WriteLine("Nothing to sell...");
                    Console.WriteLine("Press any key to continue...");
                }
            }

        public void BuyMenu()
            {
                Console.Clear();

                List<Item_Cost> items = Traveler.location.ItemsToTrade;

                PrintItems(items);

                var itemIndex = UI.ElicitInput("Which item would you like to buy: ", 1, items.Count);
           // Console.Write("Option:");

            if (!itemIndex.cancelled)
                {
                    Traveler.BuyItem(items[itemIndex.input - 1]);
                }
            }

        public void PrintItems(List<Item_Cost> items)
            {
                for (int i = 0; i < items.Count; ++i)
                {
                    var item = items[i];
                    var cost = Traveler.location.CostOf(item);

                    Console.WriteLine($"{i + 1}. {item.name} - {cost:F2} Coins");
                }
            }

        public void TravelMenu()
            {
                var done = false;
                int selector = 0;
                int count = locations.Count;

                do
                {
                    Console.Clear();
                    Console.WriteLine("Select which Planet you would like to travel to:");

                    PrintLocationsAndDistances(selector);

                    var key = UI.ElicitInput("");


                    switch (key)
                    {
                        case ConsoleKey.DownArrow:
                           selector++;
                           selector %= count;
                            break;
                        case ConsoleKey.UpArrow:
                            selector--;
                           selector = (selector + count) % count;
                            break;
                    case ConsoleKey.D1:
                       // TravelMenu();
                        break;
                    case ConsoleKey.D2:
                        //BuyMenu();
                        break;
                    case ConsoleKey.D3:
                       // SellMenu();
                        break;
                        case ConsoleKey.Q:
                            done = true;
                            break;
                        case ConsoleKey.RightArrow:
                        case ConsoleKey.Enter:
                            done = true;
                            //var warpSpeed = 5;
                            Traveler.TravelTo(locations[selector]);
                            break;
                    }
                } while (!done);
            }

        public void PrintLocationsAndDistances(int selector)
            {
                for (int i = 0; i < locations.Count; ++i)
                {
                    Location_Destination destination = locations[i];

                    var distance = Traveler.location.DistanceTo(destination);

                    //Console.Write($" - ");

                    if (i == selector)
                    {
                        UI.Highlight();
                    }

                    Console.WriteLine($"Location {destination.name}: Approximately {distance:F2} Light Years away.");

                    UI.ResetColors();
                }
            }
        }
    }

