using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagnesWithCodeV2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            String result = " ";

            int[] index = new int[4];

            index[0] = 1;
            index[1] = 3;
            index[2] = 0;
            index[3] = 2;

            String[] islands = new String[4];

            islands[0] = "Bermudy";
            islands[1] = "Fij";
            islands[2] = "Azory";
            islands[3] = "Cozumel";

            int y = 0;
            int refNum;

            while( y < 4)
            {
                refNum = index[y];
                result += "\nWyspa = ";
                result += islands[refNum];
                y = y + 1;



            }
            MessageBox.Show(result);

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
