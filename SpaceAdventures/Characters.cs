using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceAdventures
{
    public class Characters
    {
        


        public Location_Destination location;


       public List<Item_Cost> inventory = new List<Item_Cost>();


        public double AddedAge = 20;
        public decimal money;

        public Characters(Location_Destination location)
            {
                this.location = location;
                money = 10000M;
            }



            public void TravelTo(Location_Destination destination)
            {
                var LightYears = location.DistanceTo(destination);
                var velocity = WarpMathEquation.WarpToLight();

                AddedAge += LightYears / velocity;
            

            location = destination;
            }



            public void BuyItem(Item_Cost item)
            {
                money -= location.CostOf(item);
                inventory.Add(item);
            }



            public void SellItem(Item_Cost item)
            {
                money += location.CostOf(item);
                inventory.Remove(item);
            }
        }
    }

