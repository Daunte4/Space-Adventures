using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SpaceAdventures
{
    public static class Intro
    {
        public static void Display()
        {
            string Title = @"
______    _ _ _               _____ _    _           
|  ___|  | | (_)             /  ___| |  (_)          
| |_ __ _| | |_ _ __   __ _  \ `--.| | ___  ___  ___ 
|  _/ _` | | | | '_ \ / _` |  `--. \ |/ / |/ _ \/ __|
| || (_| | | | | | | | (_| | /\__/ /   <| |  __/\__ \
\_| \__,_|_|_|_|_| |_|\__, | \____/|_|\_\_|\___||___/
                       __/ |                         
                      |___/                          ";



            Console.Title = Title;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(Title);
            Console.ResetColor();
        }
        public static string StartGame()
        {
            //Console.Clear();
            string name = "";
            bool check = false;
            while (check == false)

            {
                Console.WriteLine("Select from the options below.\n" + "1.Start Game " + " 2. Quit");
                name = Console.ReadLine();
                switch (name)
                {
                    case "1":
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("\n\nType in your name to start the game: ");
                        Console.ResetColor();

                        name = ($"{Console.ReadLine()}");

                        check = true;
                        break;
                    case "2":
                        Console.WriteLine("Thanks for playing.");

                        check = true;
                        break;
                    default:
                        Console.WriteLine("Invalid Selection");
                        check = false;
                        break;
                }

            }
            return name;
        }
        public static string GenderType()
        {
            string Gender = "";
            bool check = false;
            while (check == false)
            {
                Console.WriteLine("\nWhat is your gender?\n" + "1.Male " + " 2.Female " + " 3. Quit");
                Gender = Console.ReadLine();
                switch (Gender)
                {
                    case "1":
                        Console.WriteLine("You selected Male." +
                            "\nYou are starting off with 1000 Coins");
                        check = true;
                        break;
                    case "2":
                        Console.WriteLine("You selected Female." +
                            "\nYou are starting off with 1000 Coins");
                        check = true;
                        break;
                    case "3":
                        Console.WriteLine("Thanks for playing.");
                        check = true;
                        break;
                    default:
                        Console.WriteLine("Invalid Selection");
                        check = false;
                        break;
                }

            }
            return Gender;
        }
        public static void CompellingStory()
        {
            // string prompt = "Press any key to continue...";

            Console.Clear();
            Console.Clear();
            Console.WriteLine("Krato following Galiath, His father legacy of remaining the God of Space." +
                              "\nAfter suffering his fathers Death due to the age 70, krato knew this day was coming at the Age 20.\n");

            Thread.Sleep(3000);

            Console.WriteLine("He now is  known as the God of Space. " +
                             "\nThat will encounter difficult situations due to krato being the youngest ever to " +
                               "become The God of Space.\n");

            Thread.Sleep(3000);
            Console.WriteLine("His Mother Sonya was taken by his fathers #1 enemy Scar, to planet Liberia" +
                                  " which is 500 Light years from Earth,\n");

            Thread.Sleep(3000);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("But due to the Space ship he has can only travel 50 light years.\n");

            Thread.Sleep(3000);
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Krato will have to travel from planet to planet , Trading Goods," +
                                   "Gathering the amount of money he needs to buy a Better Space Ship.\n");

            Thread.Sleep(3000);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("When he reaches planet Liberia he will have to make," +
                                  "The biggest decison of his life, to Trade it all" +
                                  ",Give up his fathers legacy to Scar by handing him the" +
                                  " Crown, passed down to him in order to get his mother back");
            Console.ReadLine();
            Thread.Sleep(5000);

        }

        public static void ClosingMessage(Quit quitReason)
        {
            Console.Clear();

            switch (quitReason)
            {
                case Quit.UserQuit:
                    Console.WriteLine("Say it ain't so. Please don't leave.\n\n");
                    break;
                case Quit.Age:
                    Console.WriteLine("You have reached the age of 70 it's time to retire back home.\n\n");
                    break;
                case Quit.OutOfMoney:
                    Console.WriteLine("Nooooo. Now you are broke. You better run they are looking for you.\n\n");
                    break;
                case Quit.DontQuit:
                    throw new NotImplementedException("Shouldn't be quitting with DontQuit reason");
            }
        }
    }
}
