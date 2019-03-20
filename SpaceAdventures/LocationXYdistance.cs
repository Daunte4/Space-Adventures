using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace SpaceAdventures
{

    public class LocationXYdistance
    {
        public string name;
        public string description;

        double yPos;
        double xPos;

        decimal tradeRate;

        public List<Item> items;
       

public LocationXYdistance(string name, string description, double yPos, double xPos, List<Item> items, decimal tradeRate = 1.0M)
        {
            this.name = name;
            this.description = description;
            this.yPos = yPos;
            this.xPos = xPos;
            this.tradeRate = tradeRate;
            this.items = items;
        }
        

        public double DistanceTo(LocationXYdistance destination) =>

         (Math.Sqrt(Math.Pow((destination.xPos - this.xPos), 2) + Math.Pow((destination.yPos - this.yPos), 2)));
    



        public decimal CostOf(Item item) => item.cost * tradeRate;
    }
}
