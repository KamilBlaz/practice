using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DistanceCalculator
{
    public partial class Form1 : Form
    {
        int countStart;
        int countEnd;
        double milesTraveled, reimbutseRate = 0.39, amountOwed;
        int kilometers;

        private void button1_Click(object sender, EventArgs e)
        {
            countStart = (int)numericUpDown1.Value;
            countEnd = (int)numericUpDown2.Value;
            if ( countStart <= countEnd)
            {
                milesTraveled = countEnd -= countStart;
                amountOwed = milesTraveled *= reimbutseRate;
                label1.Text = amountOwed.ToString() + " zl";

            }
            else
            {
                MessageBox.Show("Poczatkowy stan licznika musi być mniejszy niż końcowy");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kilometers = countEnd - countStart;

            MessageBox.Show(kilometers + "kilometrów", "Przebyta odległość");
        }

        public Form1()
        {
            InitializeComponent();

            /* Convert example    
            int myInt = 10;
            byte myByte = (byte)myInt;
            double myDouble = (double)myByte;
            bool myBool = (bool)myDouble;
            string myString = "false";
            myBool = (bool)myString;
            myString = (string)myInt;
            myString = myInt.ToString();
            myBool = (bool)myByte;
            myByte = (byte)myBool;
            short myShort = (short)myInt;
            char myChar = 'x';
            myString = (string)myChar;
            long myLong = (long)myInt;
            decimal myDecimal = (decimal)myLong;
            //myString = myString + myInt + myByte + myDouble + myChar;
            */


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
