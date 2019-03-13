using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceAdventures
{
    class App
    {
        public void Run()
        {

            StartGame();
            Name();
            CharacterFeatures();
            Console.Clear();

            CompellingStory();

        }

        private void StartGame()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("==============================================================================");
            Console.WriteLine("        Welcome to the one and only Space Adventures.");
            Console.WriteLine("==============================================================================");
            Console.ResetColor();
        }

        private string Name()
        {
                string name = "";
                

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Type in your name to start the game: ");
                Console.ResetColor();

            name = ($"{Console.ReadLine()}");
            return name;
            
        }

        private void CharacterFeatures()
        {
            Console.WriteLine("Enter the appropriate numbers below.");
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("Are you a" + " 1.Male " + " 2.Female");
                   int Choice = int.Parse(Console.ReadLine());
            if (Choice == 1)
            {

            }
            else if (Choice == 2)
            {

            }

            Console.WriteLine("Which planet are you starting on?\n"+"1.Earth " + " 2.Alpha Centour " + " 3.Pluto");
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



            Console.WriteLine("What resouce do you want to start with?\n"+"1.Money " + " 2.Animals " + " 3.Crops " + " 4.Jelwery");
            int Choi = int.Parse(Console.ReadLine());
            if (Choi == 1)
            {

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

        private void CompellingStory()
        {
            Console.WriteLine($"Your father was one of the best traders in the Galaxy." +
                " He traded things from Animals to Crops and even Jelwery. But sadly he was taken" +
                " away from you when you were nine. You have had to stay home with your mother for " +
               " the past eleven year but sadly she died of old age. Now that you are twenty you are" +
               " going off to the follow in your fathers footsteps.  Lets see if you have what it takes!");

        }


    }
}
