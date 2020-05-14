using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Lab1
{
    public class Bet
    {
        public int Amount; 
        public int Dog; 
        public Guy Bettor; 

        public string GetDescription() {
            if (Amount == 0){
                return "hasn't place a bet  yet";
            }
            else{
                return this.Bettor.Name + " bet " + Amount + " on Dog number: " + Dog;
            }
            


        }

        public int PayOut(int Winner) {
            if (Dog == Winner)
            {
                return this.Amount;
            }
            else
            {
                return -this.Amount;

            }
        }
    }
}
