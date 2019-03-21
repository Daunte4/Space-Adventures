using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceAdventures
{
    public class Location
    {

        public string name;

        double X;
        double Y;

        decimal tradeRate;

        public List<Item> items;

        public Location(string name, double X, double Y, List<Item> items, decimal tradeRate = 1.0M)
        {
            this.name = name;
            this.X = X;
            this.Y = Y;
            this.tradeRate = tradeRate;
            this.items = items;

        }

        public double DistanceTo(Location destination) =>

             (Math.Sqrt(Math.Pow((destination.X - this.X), 2) + Math.Pow((destination.Y - this.Y), 2)));




        public decimal CostOf(Item item) => item.cost * tradeRate;
    }
    public class Item
    {
        public string name;
        public decimal cost;

        public Item(string name, decimal cost)
        {
            this.name = name;
            this.cost = cost;
        }
    }


    public static class MathEquation
    {
        public static double WarpToLight(double warp) //WarpToLight
        {

            warp = 5;

            double a = (10 / 3.0);
            double b = (-11 / 3.0);
            double c = (10 - warp);
            double velocity = (Math.Pow(warp, a)) + (Math.Pow(c, b));
            double distance = (velocity * (0.0079945 * 1.0));

            return velocity;

        }
    }
    public enum Quit { DontQuit, UserQuit, Age, OutOfMoney };
}
