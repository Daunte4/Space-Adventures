using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceAdventures
{
    public class Ship
    {
        public void Run()
        {
            Console.Clear();
            StartLocation();
            ShipName();
            ShipLocation();
            ShipStatus();


        }
        public void StartLocation()
        {
            Console.WriteLine("\nYou are starting at the planet earth.\n");
            Console.Read();
        }
        public void ShipName()
        {
            Console.WriteLine("\nYour ship is called: The Lady Grey");
            Console.Read();
        }
        public void ShipStatus()
        {
            Console.WriteLine("\nYour ship that you started with can only travel 500 light years.\n");
            Console.Read();
        }


        public void ShipLocation()
        {
            string name = "";
            //Console.Clear();
            bool check = false;
            while (check == false)

            {
                Console.WriteLine("\nSelect from the options below.\n" + "1. Disembarking " + " 2. Plotting a course");
                name = Console.ReadLine();
                switch (name)

                {
                    case "1":
                        Console.WriteLine("Disembarking...");
                        Console.ReadLine();
                        break;
                    case "2":
                        Console.WriteLine("Plotting a course...");
                        Console.ReadLine();
                        break;
                }
            }


        }
    }
}