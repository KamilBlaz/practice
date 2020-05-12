using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PartyCosts
{
    public partial class Form1 : Form
    {
        DinnerParty dinnerparty;
        public Form1()
        {

            InitializeComponent();
            dinnerparty = new DinnerParty() { NumberOfPeople = 5 };
            dinnerparty.SetHealtyOption(true);
            dinnerparty.CalculateCostOfDecorations(false);
            DisplayDinnerPartyCost();

        }

        private void DisplayDinnerPartyCost()
        {
            decimal Cost = dinnerparty.CalculateCost(healthyBox.Checked);
            costLabel.Text = Cost.ToString("c");

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            dinnerparty.NumberOfPeople = (int)numericUpDown1.Value;
            DisplayDinnerPartyCost();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            dinnerparty.CalculateCostOfDecorations(checkBox1.Checked);
            DisplayDinnerPartyCost();

        }

        private void healthyBox_CheckedChanged(object sender, EventArgs e)
        {
            dinnerparty.SetHealtyOption(healthyBox.Checked);
            DisplayDinnerPartyCost();
        }
    }
}
