using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceAdventures
{
    class Intro
    {
        static string CharacterName;

        public void Run()
        {
            GameTitle();
            //NameCharacter();
            //Choice();
        }



        static void Choice()
        {
            string input = "";
            Console.WriteLine("a: choose to Trade");
            Console.WriteLine("");
            Console.WriteLine("-------------");
            Console.WriteLine("");
            Console.WriteLine("b: choose to skip");
            Console.WriteLine(CharacterName + " which choice will you choose? A or B?");
            input = Console.ReadLine();
            if (input.ToLower() == "a")
            {
                Console.WriteLine("You've chosen path A!");
            }
            else
            {
                Console.WriteLine("You've chosen path B!");
            }
        }
        static void NameCharacter()
        {
            Console.WriteLine("What would you like your character's name to be?");
            CharacterName = Console.ReadLine();
            Console.WriteLine("");

            Console.WriteLine("");
            Console.WriteLine("Great! Your Character is now named " + CharacterName);
        }
        static void GameTitle()
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
            //Console.WriteLine("Process Enter ");
            //Console.ReadKey();
            GamePicture();
        }

        static void GamePicture()
        {
            string GamePicture = @"                                                                                    
                                                                       :::::::::                                                       
                                                                 ******:::::::::******                                                           
                                                                  *****:::::::::*****                                                         
                                                                 ******:::::::::******                                                           
                                                                    **:::::::::::**                                                              
                                                                 ***::::*******::::***                                                           
                                                                 *:::::*       *:::::*                                                           
                                                                ///////         \\\\\\\                                                                                                                                                                         
                                                              /:::::/             \:::::\                                                                                                                                  
                                                          /:::::/                     \:::::\                                                                                                                                      
                                                  /:::::/                                     \:::::\                                            
                                                 ||||||| ||||||| ||||||| ||||||| ||||||| |||||||\|||||||                                                                                           
                                                   ////////////////////||||||||||\\\\\\\\\\\\\\\\\\\\\\                                                                                                      
                                                  //:::::/:::::/::::/:::::/   \:::::\:::::\:::::\::::\\                         
                                                       \/:::::/:::::/::::/     \::::::\:::\::::\/                       
                                                              \::::\::::/       \::::\::::/                      
                               
                                                                                                                  ";


            Console.Title = GamePicture;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(GamePicture);
            Console.ResetColor();
            Console.WriteLine("Process Enter ");
            Console.ReadKey();
            Console.Clear();
        }
    }


}


    

