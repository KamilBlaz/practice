using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Lab1
{
   public class Guy
    {
        public string Name;
        public Bet MyBet; 
        public int Cash; 

        
        public RadioButton MyRadioButton; 
        public Label MyLabel; 

        public void UpdateLabels() {
            MyRadioButton.Text = Name + " has " + Cash + "zl";
            MyLabel.Text = Name + " hasn't place a bet  yet ";
        }
        public void ClearBet() {
            MyBet.Amount = 0;
            MyBet.Dog = 0;
            MyBet.Bettor = this;
        } 
        public bool PlaceBet(int AmountBet, int DogToWin) {
            if(Cash >= AmountBet)
            {
                MyBet.Amount = AmountBet;
                MyBet.Dog = DogToWin;
                MyBet.Bettor = this;
                return true;
            }
            else
            {
                return false;
            }
           
        }

        public void Collect(int Winner) {
            Cash += MyBet.PayOut(Winner);
            this.UpdateLabels();
        }



    }
}
