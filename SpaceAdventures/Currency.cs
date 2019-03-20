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
                Console.WriteLine("\nHow much will you want to spend if you only have 1000$?" + "\n 1. Buy jewlry " +
                    "\n 2. Buy fuel" + "\n 3. Buy water" + "\n 4. buy Plant seeds" + "\n 5. Animals ");
                   
                Results = Console.ReadLine();
                switch (Results)
                {
                    case "1":
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("You selected Jewlry to Buy");
                        check = true;
                        break;

                    case "2":
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("you selected Fuel to Buy");
                        check = true;                      
                        break;

                    case "3":
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("you selected water to Buy");
                        check = true;                        
                        break;

                    case "4":
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("you selected plant seeds to Buy");
                        check = true;                       
                        break;

                    case "5":
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("you selected Animals to Buy");
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
                Console.WriteLine("\nWhat choice will you make?\n" + "\n 1. Trade current item you puchased for another currency" + 
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




