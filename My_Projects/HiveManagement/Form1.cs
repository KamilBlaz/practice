using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HiveManagement
{
    public partial class Form1 : Form
    {
        private Queen queen;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void nextShift_Click(object sender, EventArgs e)
        {

            textBox1.Text = queen.WorkTheNextShift();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (queen.AssignWork(workerBeeJob.Text, (int)shifts.Value) == false)

                MessageBox.Show("nie ma dostpenych robotnic do wykonania zadania '" + workerBeeJob.Text + "'", "Królowa pszczół mówi.......");
            else
                MessageBox.Show("Zadanie '" + workerBeeJob.Text + "' bedzie ukończone za " + shifts.Value + " zmiany"," Królowa pszczół mówi......");
        }
    }
}
