using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LumberJack
{
    class LumberJack
    {
        private string name;
        public string Name { get { return name; } }
        private Stack<Flapjack> meal;
        public LumberJack(string name){
            this.name = name;
            meal = new Stack<Flapjack>();
        }
        public int FlapjackCount { get { return meal.Count; } }
        public void TakeFlapjacks(Flapjack food, int HowMany){

            for (int i = 0; i < HowMany; i++) {
                meal.Push(food);
            }
             

        }
        public void EatFlapjack(){
            Console.WriteLine(name + " je nalesniki");
            while(meal.Count > 0){
                Console.WriteLine(name + "zjadl " + meal.Pop().ToString().ToLower() + " nalesniki");

            }

        }
    }
}
