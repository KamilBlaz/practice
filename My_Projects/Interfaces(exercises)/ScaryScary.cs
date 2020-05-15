using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_exercises_
{
    class ScaryScary :FunnyFunny, IScaryClown {
        private int numberOfScaryThings;
        public ScaryScary(string funntThingIhave,int numberOfScaryThings):base(funntThingIhave){
            this.numberOfScaryThings = numberOfScaryThings;
        }
        public string ScaryThingIhave {  get { return "Mam" + numberOfScaryThings + " pajaków"; } }
        public void ScareLittleChildren()
        {
            Console.WriteLine("Buu! Mam Cie!");
        }
    }
}
