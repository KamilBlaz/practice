using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartyCosts
{
    
    class DinnerParty
    {
        public int NumberOfPeople;
        public decimal CostofBeveragesPerPerson;
        public decimal CostOfDecorations = 0;
        public const int CostOfFoodPerPerson = 25;

        public void SetHealtyOption(bool healthyOption) {
            if (healthyOption){
                CostofBeveragesPerPerson = 5.00M;
            } else{
                CostofBeveragesPerPerson = 20.00M;
            }
        }
        public void CalculateCostOfDecorations(bool decorationOption) {
            if (decorationOption){
                CostOfDecorations =  (NumberOfPeople * 15.00M)  + 50M;
            }
            else{
                CostOfDecorations = (NumberOfPeople * 7.50M) + 30M;
            }
     
        }

        public  decimal CalculateCost(bool healthyOption) {
            decimal sum;
            sum = CostOfDecorations + ((CostofBeveragesPerPerson + CostOfFoodPerPerson) * NumberOfPeople);
            if (healthyOption) { 
                return sum * .95M;
            } else {
                return sum;
            }

            
        
        }



    }
}
