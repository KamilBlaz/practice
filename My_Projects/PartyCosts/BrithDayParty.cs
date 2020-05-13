using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartyCosts
{
     class BrithDayParty
    {
        public const int CostOfFood = 25;
        public int NumberOfPeople { get; set; }
        public bool FancyDecorations { get; set; }
   
        public string CakeWriting { get; set; }

        public BrithDayParty(int numberOfPeople, bool fancyDecorations, string cakeWirting)
        {
            this.NumberOfPeople = numberOfPeople;
            this.FancyDecorations = fancyDecorations;
            this.CakeWriting = cakeWirting;
        }

        private int ActualLength
        {
            get
            {
                if (CakeWriting.Length > MaxWritingLength())
                    return MaxWritingLength();
                else
                    return CakeWriting.Length;
                    
            }

        }
        
        private int CakeSize(){
           if(NumberOfPeople <= 4)
                return 20;
           else
                return 40;
           
        }
        private int MaxWritingLength()
        {
            if (CakeSize() == 8)
                return 16;
            else
                return 40;
        }
         
        public bool CakeWritingTooLong
        {
            get
            {
                if (CakeWriting.Length > MaxWritingLength())
                    return true;
                else
                    return false;
            }
        }
        private decimal CalculateCostOfDecorations()
        {
            decimal costOfDecorations;
            if (FancyDecorations)
                costOfDecorations = (NumberOfPeople * 15.00M) + 50M;
            else
                costOfDecorations = (NumberOfPeople * 7.50M) + 30M;

            return costOfDecorations;
        }

        
        public decimal Cost
        {
            get
            {
                decimal totalCost = CalculateCostOfDecorations();
                totalCost += CostOfFood * NumberOfPeople;
                decimal cakeCost;
                if (CakeSize() == 20)
                    cakeCost = 40M + ActualLength * .25M;
                else
                    cakeCost = 75M + ActualLength * .25M;
                return totalCost + cakeCost;
            }
        }


    }
}
