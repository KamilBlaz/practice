using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_exercises_
{
    class Program
    {
        static void Main(string[] args)
        {
            TallGuy tallGuy = new TallGuy { Height = 74, Name = "Adam" };
            tallGuy.TalkAboutYourself();




            ScaryScary fingersTheCLown = new ScaryScary("duże buty", 35);
            FunnyFunny someFunnyClown = fingersTheCLown;
            IScaryClown someOtherScaryClown = someFunnyClown as ScaryScary;
            someOtherScaryClown.Honk();
;           Console.ReadKey();
        }
    }
}
