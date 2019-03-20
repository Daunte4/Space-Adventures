using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
namespace SpaceAdventures
{
   public static class MainRun
    {
        List<LocationXYdistance> locations = new List<LocationXYdistance>();
       // Player hero;
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
        public void Run()
        {
            Character.CompellingStory();
//
         var quitReason = EventLoop();

            Character.ClosingMessage(quitReason);
        }
        private QuitReason EventLoop()
        {
            QuitReason quitReason;

            do
            {
                Console.Clear();

                // Print the current location
                Console.WriteLine($"Location: {hero.location.name}    Age: {hero.age:f2} years    Credits: {hero.money:f1}\n");

                // Print a description of that location
                Console.WriteLine(hero.location.description);

                // Provide options to the user re. things they can do
                PrintOptionList();

                var key = UI.ElicitInput();

                quitReason = ShouldQuit(HandleInput(key));
            } while (quitReason == QuitReason.DontQuit);

            return quitReason;
        }

        private QuitReason ShouldQuit(QuitReason quitReason)
        {
            QuitReason AgeCheck() => hero.age >= 70 ? QuitReason.Age : QuitReason.DontQuit;
            QuitReason MoneyCheck() => hero.money < 0 ? QuitReason.OutOfMoney : QuitReason.DontQuit;


            if (quitReason == QuitReason.DontQuit)
            {
                quitReason = AgeCheck();
            }

            if (quitReason == QuitReason.DontQuit)
            {
                quitReason = MoneyCheck();
            }

            return quitReason;
        }

        private void PrintOptionList()
        {
            Console.WriteLine();
            Console.WriteLine("1. Travel to other locations");
            Console.WriteLine("2. Buy items");
            Console.WriteLine("3. Sell items");
            Console.WriteLine("q. Quit");
        }

        private QuitReason HandleInput(ConsoleKey key)
        {
            switch (key)
            {
                case ConsoleKey.Q:
                    return QuitReason.UserQuit;
                case ConsoleKey.D1:
                    TravelMenu();
                    break;
                case ConsoleKey.D2:
                    BuyMenu();
                    break;
                case ConsoleKey.D3:
                    SellMenu();
                    break;
            }

            return QuitReason.DontQuit;
        }
        */
   // }
//}


