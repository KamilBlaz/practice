using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu
{
    class MenuMaker
    {
        public Random Randomizer;

        string [] Meats = { "Roast Beef", "Salami", "Turkey", "Ham", "Pork" };
        string [] Condiments = { "Yellow Mustard", "Brown Mustard", "Honey Mustard", "Mayonnaise", "Spice", "French sauce" };
        string[] Breads = { "Rice Bread", "White Bread", "Cereal Bread", "Pumpernickel Bread", "Italian Bread", "Roll" };

        public string GetMenuItem()
        {
            string randomMeat = Meats[Randomizer.Next(Meats.Length)];
            string randomCondiment = Condiments[Randomizer.Next(Condiments.Length)];
            string randomBread = Breads[Randomizer.Next(Breads.Length)];
            return randomMeat + " , " + randomCondiment + " , " + randomBread;

        }
            
            
            

    }
}
