﻿using System;
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
======================================================

______    _ _ _               _____ _    _           
|  ___|  | | (_)             /  ___| |  (_)          
| |_ __ _| | |_ _ __   __ _  \ `--.| | ___  ___  ___ 
|  _/ _` | | | | '_ \ / _` |  `--. \ |/ / |/ _ \/ __|
| || (_| | | | | | | | (_| | /\__/ /   <| |  __/\__ \
\_| \__,_|_|_|_|_| |_|\__, | \____/|_|\_\_|\___||___/
                       __/ |                         
                      |___/                    

======================================================
";



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
                Console.WriteLine("\tSelect from the options below.\n" + "\t   1.Start Game " + " 2. Quit");
                Console.Write("\t\tMy option is: ");
                name = Console.ReadLine();
                switch (name)
                {
                    case "1":
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Thank you for wanting to play the game (^_^)");
                        Console.Write("\n\nPlease type in your name to start the game: ");
                        Console.ResetColor();

                        name = ($"{Console.ReadLine()}");

                        check = true;
                        break;
                    case "2":
                        Console.WriteLine("Thanks for playing.");

                        check = false;
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
            //
//while (check == false)
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
             string prompt = "Press any key to continue...";

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("you are following Galiath, your father legacy of remaining the God of Space." +
                              "\nAfter suffering your fathers Death due to the age 70, you knew this day was coming at the Age 20.\n");

            Thread.Sleep(5000);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("He now is  known as the God of Space. " +
                             "\nThat will encounter difficult situations due to being the youngest ever to " +
                               "become The God of Space.\n");

            Thread.Sleep(10000);
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("your Mother Sonya was taken by your fathers #1 enemy Scar, to planet Liberia" +
                                  " which is 500 Light years from Earth,\n");

            Thread.Sleep(10000);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("But due to the Space ship you have can only travel 500 light years.\n");

            Thread.Sleep(10000);
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("you will have to travel from planet to planet , Trading Goods," +
                                   "Gathering the amount of money he needs to buy Fuel when needing to travel back to Earth.\n");

            Thread.Sleep(10000);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("When he reaches planet Liberia he will have to make," +
                                  "The biggest decison of his life, to Trade it all" +
                                  ",Give up his fathers legacy to Scar by handing him the Crown" +
                                  "\npassed down to him in order to get his mother back to Earth, or he will have to fight Scar.");
            Thread.Sleep(500);

            Console.WriteLine("\n\nPress any key to continue.");
            Console.ReadLine();
            

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
                    Console.WriteLine("You have reached the AddedAge of 70 it's time to retire back home.\n\n");
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