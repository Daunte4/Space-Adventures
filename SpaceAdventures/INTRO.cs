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
                string Picture = @"                                                                                    
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


                Console.Title = Picture;
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(Picture);
                Console.ResetColor();
                Console.WriteLine("Process Enter ");
                Console.ReadKey();
                Console.Clear();
            }
        }

       
    }


    

