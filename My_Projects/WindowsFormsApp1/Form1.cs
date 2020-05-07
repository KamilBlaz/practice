using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Guy joe;
        Guy bob;
        int bank = 100;
       

        public void UpdateForm()
        {
            joesCashLabel.Text = joe.Name + " ma " + joe.Cash + " zl";
            bobCashLabel.Text = bob.Name + " ma " + bob.Cash + "zl";
            bankCashLabel.Text = "Bank ma " + bank + " zl";
        }

        public Form1()
        {
            InitializeComponent();
            bob = new Guy() { Cash = 100, Name = "Bob" };
            joe = new Guy() { Cash = 50, Name = "Joe" };
           

            joe = new Guy();
            joe.Name = "Joe";
            UpdateForm();
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {


        }



        private void buttonFirst_Click(object sender, EventArgs e)
        {
            while (Visible)
            {
                for (int c = 0; c <= 255 && Visible; c++)
                {
                    this.BackColor = Color.FromArgb(c, 255 - c, c);
                    Application.DoEvents();
                    System.Threading.Thread.Sleep(3);


                }
                for (int c = 254; c >= 0 && Visible; c--)
                {
                    this.BackColor = Color.FromArgb(c, 255 - c, c);
                    Application.DoEvents();
                    System.Threading.Thread.Sleep(3);


                }
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int len = Talker.BlahlahBlah(textBox1.Text, (int)numericUpDown1.Value);
            MessageBox.Show("Dlugosc wiadomosci to " + len);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string result = "";
            Echo e1 = new Echo();
            Echo e2 = new Echo();
            int x = 0;

            while(x < 4)
            {
                result = result + e1.Hello() + "\n";
                e1.count = e1.count + 1;
                if(x == 3)
                {
                    e2.count = e2.count + 1;
                }
                if(x > 0)
                {

                    e2.count = e2.count + e1.count;

                }
                x = x + 1;

            }

            MessageBox.Show(result + "Licznik" + e2.count);

        }
        public class Echo
        {
            public int count = 0;
            public string Hello()
            {
                return "witaaaj....";
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(bank >= 10)
            {
                bank -= joe.ReceiveCash(10);
                UpdateForm();
            }
            else
            {
                MessageBox.Show("Bank nie posiada takiej ilosci pieniędzy");
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            bank += bob.GiveCash(5);
            UpdateForm();

        }
    }
}
