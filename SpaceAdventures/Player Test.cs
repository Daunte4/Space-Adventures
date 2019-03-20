using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceAdventures
{
    public class Player
    {
        public double age = 20;
        public decimal money;

        public Location location;
        public List<Item> inventory = new List<Item>();



        public Player(Location location)
        {
            this.location = location;
            money = 1000M;
        }



        public void TravelTo(Location destination, double warp)
        {
            var distance = location.DistanceTo(destination);
            var speed = Utility.WarpSpeedToLightSpeed(warp);

            age += distance / speed;

            location = destination;
        }

        public void BuyItem(Item item)
        {
            money -= location.CostOf(item);
            inventory.Add(item);
        }

        public void SellItem(Item item)
        {
            money += location.CostOf(item);
            inventory.Remove(item);
        }
    }
}
