using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//This is were i run my code through
namespace SpaceAdventures
{
   public class Program
    {
       public static void Main(string[] args)
        {
            Intro.Display();
            Intro.StartGame();
            Intro.GenderType();
            Intro.CompellingStory();

            Planet.PlanetInfomaton();

            new Main_Class().Run();
        }
    }
}

