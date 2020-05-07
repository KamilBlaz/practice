using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class Talker
    {
       
        public static int BlahlahBlah(string thingtoSay, int numberOfTimes)
        {
            string finalString = "";
            for(int count = 1;count <= numberOfTimes; count++)
            {
                finalString = finalString + thingtoSay + "\n";

            }
            MessageBox.Show(finalString);
            return finalString.Length;

        }

        
    }
}
