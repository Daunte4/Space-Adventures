using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceAdventures
{
   public  class App
    {
        List<LocationXYdistance> locations = new List<LocationXYdistance>();
        Player hero;
        public App()
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
                             "The planet of pie",
                             11.31371, 11.31371,
                             new List<Item>() { honey, illegalArms, beer },
                             (decimal)11.31371));
            locations.Add(
             new LocationXYdistance("Risa planet",
                          "The planet of pie",
                          55.86144, 55.86144,
                          new List<Item>() { honey, illegalArms, beer },
                          (decimal)11.31371));

            locations.Add(
             new LocationXYdistance("Nibiru planet",
                          "The planet of pie",
                          353.55339, 353.55339,
                          new List<Item>() { honey, illegalArms, beer },
                          (decimal)11.31371));

            hero = new Player(LocationXYdistance[0]);
        }
        public void Run()
        {
            Story.Intro();

            var quitReason = EventLoop();

            Story.ClosingMessage(quitReason);
        }
    }
}
