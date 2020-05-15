using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_exercises_
{
    class TallGuy : IClown
    {
        public string FunnyThingIHave { get { return "whatever"; } }
        public void Honk(){
            Console.WriteLine("Tut tuut!");
        }
        public string Name;
        public int Height;
        public void TalkAboutYourself(){
            Console.WriteLine("Nazywam sie " + Name + " i mam " + Height + "centymetrów wzorstu");

        }
    }
}
