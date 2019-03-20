using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceAdventures
{
    public class Currency
    {
        public void Run()
        {
            Money();
            Jewlery();
            Water();
            Fuel();
            PlantSeeds();
            Choices();
            Results();

        }

        public void Results()
        {
            string Results = "";
            bool check = false;
            while (check == false)
            {
               Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nHow many credits do you want to trade?\n" + "\n 1. 200 Credits for 100$" +
                   "\n 2. 250 credits for 100 pieces of Jewlry" +
                    "\n 3. 100 credits for 100 bottles of water"+
                   "\n 4. 150 credits for the value of 100 pounds of Fuel" +
                   "\n 5. 125 credits for the value of 100 packets of plant seeds");
                Results = Console.ReadLine();
                switch (Results)
                {
                    case "1":
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("You selected 200 credits for 100$");
                        check = true;
                        break;

                    case "2":
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("you selected 250 credits for 100 pieces of jewlry");
                        check = true;                      
                        break;

                    case "3":
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("you selected 100 credits for bottles of water");
                        check = true;                        
                        break;

                    case "4":
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("you selected 150 credits for 100 pounds of fuel");
                        check = true;                       
                        break;

                    case "5":
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("you selected 125 credits for 100 packets of plant seeds");
                        check = true;                       
                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("invalid Selection");
                        check = false;
                        break;
                }
            }
        }

        public void Choices()
        {
            string Choices = "";
            bool check = false;
            while(check == false)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nWhat choice will you make?\n" + "\n 1.Trade a Certain amount of Credit for Money" + 
                    "\n 2.Deny Trade and leave plant" + "3.quit");
                Console.ForegroundColor = ConsoleColor.Red;
                Choices = Console.ReadLine();
                switch (Choices)
                {
                    case "1":
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("You selected to Trade.");
                        check = true;
                        break;

                    case "2":
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("You selected to Deny the Trade");
                        check = true;
                        Console.WriteLine("You have to either find another offer to Trade or you will be stuck on this planet");
                        check = true;
                        break;

                    case "3":
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("you selected to Quit");
                        check = true;
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("invalid Selection");
                        check = false;
                        break;
                }


            }
        }

        int Box = 100;

        public double Money()
        {
            double MoneyOption = 1;
            double money = Box * 2;
            MoneyOption = MoneyOption * money;
            Console.WriteLine($"\n{MoneyOption} credits for the valuse of 100 dollars.");
            return MoneyOption;

        }
        public double Jewlery()
        {
            double JewleryOption = 1;
            double jewlery = Box * 2.5;
            JewleryOption = JewleryOption * jewlery;
            Console.WriteLine($"\n{JewleryOption} credits for the valuse of 100 pieces of Jewlery.");
            return JewleryOption;
        }
        public double Water()
        {
            double WaterOption = 1;
            double water = Box * 1;
            WaterOption = WaterOption * water;
            Console.WriteLine($"\n{WaterOption} credits for the valuse of 100 bottles of Water.");
            return WaterOption;
        }
        public double Fuel()
        {
            double FuelOption = 1;
            double fuel = Box * 1.5;
            FuelOption = FuelOption * fuel;
            Console.WriteLine($"\n{FuelOption} credits for the valuse of 100 pounds of Fuel.");
            return FuelOption;
        }
        public double PlantSeeds()
        {
            double PlantOption = 1;
            double Plant = Box * 1.25;
            PlantOption = PlantOption * Plant;
            Console.WriteLine($"\n{PlantOption} credits for the valuse of 100 packets of Plant Seeds.");
            return PlantOption;
        }
        
    }
}




//*

//public class Metals // get a base modifier of 2
//{
//    Creds metalCredits = new Creds();
//    public void Platinium() // will have a modifier of 3
//    {
//        Console.WriteLine("One of the better metals available, not as rare as palladium, though better for different projects." +
//            "The base modifier for platinium 3");
//        int metalModifier = 3;
//        metalCredits.MetalCreds(metalModifier);
//    }

//    public void Palladium() // will have a modifier of 4
//    {
//        int metalModifier = 4;
//        metalCredits.MetalCreds(metalModifier);
//    }

//    public void Titanium()
//    {
//        int metalModifier = 2;
//        metalCredits.MetalCreds(metalModifier);
//    }
//}




