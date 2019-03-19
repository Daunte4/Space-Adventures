using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SpaceAdventures
{
    class Character
    {
        public void Run()
        {

            //StartGame();
            CompellingStory();
            Name();
            GenderType();
            Currency();

        }

        //Code to enter you name to start game
        public string Name()
        {
            //Console.Clear();
            string name = "";


            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\n\nType in your name to start the game: ");
            Console.ResetColor();

            name = ($"{Console.ReadLine()}");
            return name;

        }

        //code to choice your gender
        public string GenderType()
        {
            string Gender = "";
            bool check = false;
            while (check == false)
            {
                Console.WriteLine("\nWhat is your gender?\n" + "1.Male " + " 2.Female ");
                Gender = Console.ReadLine();
                switch (Gender)
                {
                    case "1":
                        Console.WriteLine("You selected Male.");
                        check = true;
                        break;
                    case "2":
                        Console.WriteLine("You selected Female.");
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

        //code to choice your Character and what resource they start with.
        public string Currency()
        {
            string Curr = "";
            bool check = false;
            while (check == false)
            {
                Console.WriteLine("\nWhat resouce do you want to start with?\n" + "1.Money " + " 2.Jewlery " + " 3.Water " + " 4.Fuel " + " 5.Plant Seeds");
                Curr = Console.ReadLine();
                switch (Curr)
                {
                    case "1":
                        Console.WriteLine("You selected Money.");
                        check = true;
                        break;
                    case "2":
                        Console.WriteLine("You selected Jewlery.");
                        check = true;
                        break;
                    case "3":
                        Console.WriteLine("You selected Water.");
                        check = true;
                        break;
                    case "4":
                        Console.WriteLine("You selected Fuel.");
                        check = true;
                        break;
                    case "5":
                        Console.WriteLine("You selected Plant Seeds.");
                        check = true;
                        break;

                    default:
                        Console.WriteLine("Invalid Selection");
                        check = false;
                        break;
                }

            }
            return Curr;
        }

        //Code that talks about the Story of the game.
        public void CompellingStory()
        {

            Console.WriteLine("Krato following Galiath, His father legacy of remaining the God of Space." +
                              "\nAfter suffering his fathers Death due to the age 70, krato knew this day was coming at the Age 20.\n");
            // Console.ReadLine();
            Thread.Sleep(2000);

            Console.WriteLine("He now is  known as the God of Space. " +
                             "\nThat will encounter difficult situations due to krato being the youngest ever to " +
                               "become The God of Space.\n");
            //Console.ReadLine();
            Thread.Sleep(2000);
            Console.WriteLine("His Mother Sonya was taken by his fathers #1 enemy Scar, to planet Liberia" +
                                  " which is 500 Light years from Earth,\n");
            //Console.ReadLine();
            Thread.Sleep(2000);
            Console.WriteLine("But due to the Space ship he has can only travel 50 light years.\n");
            //Console.ReadLine();
            Thread.Sleep(2000);
            Console.WriteLine("Krato will have to travel from planet to planet , Trading Goods," +
                                   "Gathering the amount of money he needs to buy a Better Space Ship.\n");
            //Console.ReadLine();
            Thread.Sleep(2000);
            Console.WriteLine("When he reaches planet Liberia he will have to make," +
                                  "The biggest decison of his life, to Trade it all" +
                                  ",Give up his fathers legacy to Scar by handing him the" +
                                  " Crown, passed down to him in order to get his mother back");
            //Console.ReadLine();
            Thread.Sleep(2000);

        }

        public void StarterMaterial()
        {
        }

        public void CharacterAge()
        {

        }
    }
}
