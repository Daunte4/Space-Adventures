using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceAdventures
{
    class Character
    {
        public void Run()
        {
            Name();
            CharacterFeatures();
            CompellingStory();
            Console.Clear();

        }
        public string Name()
        {
            string name = "";


            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Type in your name to start the game: ");
            Console.ResetColor();

            name = ($"{Console.ReadLine()}");
            return name;

        }



        public void CharacterFeatures()
        {
            Console.WriteLine("\nEnter the appropriate numbers below.");
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("\nAre you a" + " 1.Male " + " 2.Female");
            int Choice = int.Parse(Console.ReadLine());
            if (Choice == 1)
            {

            }
            else if (Choice == 2)
            {

            }

            Console.WriteLine("\nWhich planet are you starting on?\n" + "1.Earth " + " 2.Alpha Centouri:3 " + " 3.Pluto");
            int Choic = int.Parse(Console.ReadLine());
            if (Choic == 1)
            {


            }
            else if (Choic == 2)
            {

            }
            else if (Choic == 3)
            {

            }

            Console.WriteLine("\nWhat resouce do you want to start with?\n" + "1.Money " + " 2.Animals " + " 3.Crops " + " 4.Jelwery");
            int Choi = int.Parse(Console.ReadLine());
            if (Choi == 1)
            {
                Console.Write("You are starting with Money");

            }
            else if (Choi == 2)
            {

            }
            else if (Choi == 3)
            {

            }
            else if (Choi == 4)
            {

            }
            Console.ResetColor();
        }

        public void CompellingStory()
        {
            Console.WriteLine($"Your father was one of the best traders in the Galaxy." +
                               "\nHe traded things from Animals to Crops and even Jewelry." +
                                "\nBut sadly he was taken away from you when you were nine." +
                               "\nNow that you are twenty you are the past eleven year but sadly she died of old age." +
                               "\nNow that you are twenty you are going off to the follow in your fathers footsteps. " +
                               "\nLets see if you have what it takes!\n");
        }
        public void StarterGemstone()
        {
        }

        public void CharacterAge()
        {

        }
    }
}
