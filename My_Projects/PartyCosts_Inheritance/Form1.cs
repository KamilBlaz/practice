using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PartyCosts_Inheritance
{
    public partial class Form1 : Form
    {
        DinnerParty dinnerparty;
        BrithDayParty brithdayParty;
        public Form1()
        {

            InitializeComponent();

            dinnerparty = new DinnerParty((int)numericUpDown1.Value, healthyBox.Checked, checkBox1.Checked); 

            DisplayDinnerPartyCost();

            brithdayParty = new BrithDayParty((int)numberBrithday.Value, fancyBrithday.Checked, cakeWriting.Text);
            DisplayBrithDayPartyCost();

        }

        private void DisplayDinnerPartyCost()
        {
            decimal Cost = dinnerparty.Cost;
            costLabel.Text = Cost.ToString("c");

        }
        private void DisplayBrithDayPartyCost()
        {
            tooLongLabel.Visible = brithdayParty.CakeWritingTooLong;
            decimal Cost = brithdayParty.Cost;
            brithdayCost.Text = Cost.ToString("c");

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            dinnerparty.NumberOfPeople = (int)numericUpDown1.Value;
            DisplayDinnerPartyCost();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            dinnerparty.FancyDecorations = checkBox1.Checked;
            DisplayDinnerPartyCost();

        }

        private void healthyBox_CheckedChanged(object sender, EventArgs e)
        {
            dinnerparty.HealthyOption = healthyBox.Checked;
            DisplayDinnerPartyCost();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void numberBrithday_ValueChanged(object sender, EventArgs e)
        {
            brithdayParty.NumberOfPeople = (int)numberBrithday.Value;
            DisplayBrithDayPartyCost();
        }

        private void fancyBrithday_CheckedChanged(object sender, EventArgs e)
        {
            brithdayParty.FancyDecorations = fancyBrithday.Checked;
            DisplayBrithDayPartyCost();

        }

        private void cakeWriting_TextChanged(object sender, EventArgs e)
        {
            brithdayParty.CakeWriting =  cakeWriting.Text;
            DisplayBrithDayPartyCost();
        }
    }
}
