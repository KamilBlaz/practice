using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Form1 : Form
    {
        Guy[] GuysArray = new Guy[3];
        GreyHound[] GreyhoundArray= new GreyHound[4];
        Random Randomizer = new Random();

        public Form1()
        {
            InitializeComponent();
            pawelRadioButton.Checked = true;
            // init min bet label
            minimumBetLabel.Text = "Minimum  Bet:" + numericUpDown1.Minimum.ToString() + "zl";

            GreyhoundArray[0] = new GreyHound()
            {
                MyPictureBox = greyHoundFirst,
                StartingPosition = greyHoundFirst.Left,
                RaceTrackLenght = racetrackPictureBox.Width - greyHoundFirst.Width,
                MyRandom = Randomizer
            };
            GreyhoundArray[1] = new GreyHound()
            {
                MyPictureBox = greyHoundSecond,
                StartingPosition = greyHoundSecond.Left,
                RaceTrackLenght = racetrackPictureBox.Width - greyHoundSecond.Width,
                MyRandom = Randomizer
            };
            GreyhoundArray[2] = new GreyHound()
            {
                MyPictureBox = greyHoundThird,
                StartingPosition = greyHoundThird.Left,
                RaceTrackLenght = racetrackPictureBox.Width - greyHoundThird.Width,
                MyRandom = Randomizer
            };
            GreyhoundArray[3] = new GreyHound()
            {
                MyPictureBox = greyHoundFour,
                StartingPosition = greyHoundFour.Left,
                RaceTrackLenght = racetrackPictureBox.Width - greyHoundFour.Width,
                MyRandom = Randomizer
            };

            //init 3 element of Guys

            GuysArray[0] = new Guy()
            {
                Name = "Paweł",
                MyBet = null,
                Cash = 50 ,
                MyRadioButton = pawelRadioButton,
                MyLabel = pawelBetLabel,
              
            };
            GuysArray[1] = new Guy()
            {
                Name = "Kamil",
                MyBet = null,
                Cash = 75,
                MyRadioButton = kamilRadioButton,
                MyLabel = kamilBetLabel,

            };
            GuysArray[2] = new Guy()
            {
                Name = "Szymon",
                MyBet = null,
                Cash = 35,
                MyRadioButton =szymonRadioButton,
                MyLabel = szymonBetLabel,

            };

            for (int i = 0; i <= 2; i++)
            {
                GuysArray[i].UpdateLabels();
                GuysArray[i].MyBet = new Bet();
            }




        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

       

        private void startButton_Click(object sender, EventArgs e)
        {
            //Dogs take start position
            GreyhoundArray[0].TakeStartingPostition();
            GreyhoundArray[1].TakeStartingPostition();
            GreyhoundArray[2].TakeStartingPostition();
            GreyhoundArray[3].TakeStartingPostition();

            //disable race button till the end of the race
            groupBox1.Enabled = false;

            //start timer
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for(int  i = 0; i <= 3 ; i++ )
            {
                if (GreyhoundArray[i].Run())
                {
                    timer1.Stop();
                    groupBox1.Enabled = true;
                    i++;
                    MessageBox.Show("The winner DOG is  :" + i);
                    for (int j = 0; j <= 2; j++)
                    {
                        GuysArray[j].Collect(i);
                        GuysArray[j].ClearBet();
                    }
                    break;
                }
            }
        }

        private void betButton_Click(object sender, EventArgs e)
        {
            if (pawelRadioButton.Checked)
            {
                if (GuysArray[0].PlaceBet((int)numericUpDown1.Value, (int)numericUpDown2.Value))
                {
                    pawelBetLabel.Text = GuysArray[0].MyBet.GetDescription();
                }
            }
            else if (kamilRadioButton.Checked)
            {
                if (GuysArray[1].PlaceBet((int)numericUpDown1.Value, (int)numericUpDown2.Value))
                {
                   kamilBetLabel.Text = GuysArray[1].MyBet.GetDescription();
                }
            }
            else if (szymonRadioButton.Checked)
            {
                if (GuysArray[2].PlaceBet((int)numericUpDown1.Value, (int)numericUpDown2.Value))
                {
                    szymonBetLabel.Text = GuysArray[2].MyBet.GetDescription();
                }
            }
        }

        private void pawelRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            labelname.Text = "Pawel";
        }

        private void kamilRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            labelname.Text = "Kamil";
        }

        private void szymonRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            labelname.Text = "Szymon";
        }
    }
}
