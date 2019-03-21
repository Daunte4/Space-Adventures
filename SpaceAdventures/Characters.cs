using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceAdventures
{
    public class Characters
    {
        
            public double age = 20;
            public decimal money;

            public Location_Destination location;


            public List<Item_Cost> inventory = new List<Item_Cost>();



            public Characters(Location_Destination location)
            {
                this.location = location;
                money = 1000M;
            }



            public void TravelTo(Location_Destination destination, double warp)
            {
                var distance = location.DistanceTo(destination);
                var speed = WarpMathEquation.WarpToLight(warp);

                age += distance / speed;

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

