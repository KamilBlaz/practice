using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlaysLetters
{
     class Stats
    {
        public int Total = 0;
        public int Missed = 0;
        public int Correct = 0;
        public int Accuracy = 0;

        public void Update(bool correctkey)
        {
            Total++;

            if(!correctkey)
            {
                Missed++;
            }
            else
            {
                Correct++;
            }
            Accuracy = 100 * Correct / Total;

        }


    }
}
