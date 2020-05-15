using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_exercises_
{
    class FunnyFunny : IClown
    {
        private string funnyThingIHave;
        public FunnyFunny(string funnyThingIHave) {
            this.funnyThingIHave = funnyThingIHave;
        }
        public string FunnyThingIHave{
            get { return "Cześć dzieciaki! mam " + funnyThingIHave; }
        }
        public void Honk(){
            Console.WriteLine(this.FunnyThingIHave);
        }

    }
}
