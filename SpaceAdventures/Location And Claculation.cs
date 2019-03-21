using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceAdventures
{
    public static class WarpMathEquation
    {
        public static double WarpToLight() 
        {

            double warp = 5;

            double a = (10 / 3.0);
            double b = (-11 / 3.0);
            double c = (10 - warp);
            double velocity = (Math.Pow(warp, a)) + (Math.Pow(c, b));
            double distance = (velocity * (0.0079945 * 1.0));

            return velocity;

        }
    }
    public class Item_Cost
    {
        public string name;

        public decimal cost;

        public Item_Cost(string name, decimal cost)
        {
            this.name = name;
            this.cost = cost;
        }
    }

    public class Location_Destination
    {

        public string name;

        double X;
        double Y;

        decimal TradeCost;

        public List<Item_Cost> ItemsToTrade;

        public Location_Destination(string name, double X, double Y, List<Item_Cost> ItemsToTrade, decimal TradeCost = 1.0M)
        {
            this.name = name;
            this.X = X;
            this.Y = Y;
            this.TradeCost = TradeCost;
            this.ItemsToTrade = ItemsToTrade;

        }

        public double DistanceTo(Location_Destination LocDestination) =>

             (Math.Sqrt(Math.Pow((LocDestination.X - this.X), 2) + Math.Pow((LocDestination.Y - this.Y), 2)));




        public decimal CostOf(Item_Cost item) => item.cost * TradeCost;
    }
  
    public enum Quit { DontQuit, UserQuit, Age, OutOfMoney };
}
