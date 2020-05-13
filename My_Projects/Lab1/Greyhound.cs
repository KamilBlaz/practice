using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
   public class GreyHound
    {
        public int StartingPosition; 
        public int RaceTrackLenght; 
        public PictureBox MyPictureBox = null; 
        public int Location = 0; 
        public Random MyRandom; 
        
        public bool Run() {

            Location += MyRandom.Next(1, 6);
            MyPictureBox.Left = Location;
            if (MyPictureBox.Left >= RaceTrackLenght)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void TakeStartingPostition() {
            Location = 0;
            MyPictureBox.Left = StartingPosition;
        }
       


    }
}
