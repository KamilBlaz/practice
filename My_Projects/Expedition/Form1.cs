using System;
using System.Drawing;
using System.Globalization;
using System.Security.AccessControl;
using System.Windows.Forms;

namespace Expedition
{
    public partial class Form1 : Form
    {
        private Game game;
        private Random random = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1Load(object sender, EventArgs e)
        {
            game = new Game(new Rectangle(100,81,539,215));

            game.NewLevel(random);
            UpdateCharacters();
        }

        private void UpdateCharacters()
        {
            playerPictureBox.Location = game.PlayerLocation;
            playerHitPointsLabel.Text = game.PlayerHitPoints.ToString(CultureInfo.InvariantCulture);

            bool showBat = false;
            bool showGhost = false;
            bool showGhoul = false;
            int enemiesShown = 0;
           
            foreach (Enemy enemy in game.Enemies)
            {
                if (enemy is Bat)
                {
                    batPictureBox.Location = enemy.Location;
                    batHitPointsLabel.Text = enemy.HitPoints.ToString(CultureInfo.InvariantCulture);
                    if (enemy.HitPoints > 0)
                    {
                        showBat = true;
                        enemiesShown++;
                    }
                }
                else if (enemy is Ghost)
                {
                    ghostPictureBox.Location = enemy.Location;
                    ghostHitPointsLabel.Text = enemy.HitPoints.ToString(CultureInfo.InvariantCulture);
                    if (enemy.HitPoints > 0)
                    {
                        showGhost = true;
                        enemiesShown++;
                    }
                }
                else if (enemy is Ghoul)
                {
                    ghoulPictureBox.Location = enemy.Location;
                    ghoulHitPointsLabel.Text = enemy.HitPoints.ToString(CultureInfo.InvariantCulture);
                    if (enemy.HitPoints > 0)
                    {
                        showGhoul = true;
                        enemiesShown++;
                    }
                }
                else
                {
                    continue;
                }           
            }
           
            switch (showBat)
            {
                case true:
                    batPictureBox.Visible = true;
                    break;
                case false:
                    batPictureBox.Visible = false;
                    batHitPointsLabel.Text = String.Empty;
                    break;
            }

            switch (showGhost)
            {
                case true:
                    ghostPictureBox.Visible = true;
                    break;
                case false:
                    ghostPictureBox.Visible = false;
                    ghostHitPointsLabel.Text = String.Empty;
                    break;
            }

            switch (showGhoul)
            {
                case true:
                    ghoulPictureBox.Visible = true;
                    break;
                case false:
                    ghoulPictureBox.Visible = false;
                    ghoulHitPointsLabel.Text = String.Empty;
                    break;
            }

            swordPictureBox.Visible = false;
            bowPictureBox.Visible = false;
            redPotionPictureBox.Visible = false;
            bluePotionPictureBox.Visible = false;
            macePictureBox.Visible = false;
            Control weaponControl = null;

            switch (game.WeaponInRoom.Name)
            {
                case "Sword":
                    weaponControl = swordPictureBox;
                    break;
                case "Bow":
                    weaponControl = bowPictureBox;
                    break;
                case "Red Potion":
                    weaponControl = redPotionPictureBox;
                    break;
                case "Blue Potion":
                    weaponControl = bluePotionPictureBox;
                    break;
                case "Mace":
                    weaponControl = macePictureBox;
                    break;
            }

           
            inventoryPictureBox1.Visible = false;
            inventoryPictureBox1.Enabled = false;
            inventoryPictureBox2.Visible = false;
            inventoryPictureBox2.Enabled = false;
            inventoryPictureBox3.Visible = false;
            inventoryPictureBox3.Enabled = false;
            inventoryPictureBox4.Visible = false;
            inventoryPictureBox4.Enabled = false;
            inventoryPictureBox5.Visible = false;
            inventoryPictureBox5.Enabled = false;

            if (game.CheckPlayerInventory("Sword"))
            {
                inventoryPictureBox1.Visible = true;
                inventoryPictureBox1.Enabled = true;
                inventoryPictureBox1.Image = Expedition.Properties.Resources.sword;
                
            }
            if (game.CheckPlayerInventory("Bow"))
            {
                inventoryPictureBox2.Visible = true;
                inventoryPictureBox2.Enabled = true;
                inventoryPictureBox2.Image = Expedition.Properties.Resources.bow;
            }
            if (game.CheckPlayerInventory("Mace"))
            {
                inventoryPictureBox3.Visible = true;
                inventoryPictureBox3.Enabled = true;
                inventoryPictureBox3.Image = Expedition.Properties.Resources.mace;
            }
            if (game.CheckPlayerInventory("Blue Potion"))
            {
                inventoryPictureBox4.Visible = true;
                inventoryPictureBox4.Enabled = true;
                inventoryPictureBox4.Image = Expedition.Properties.Resources.potion_blue;
            }
            if (game.CheckPlayerInventory("Red Potion"))
            {
                inventoryPictureBox5.Visible = true;
                inventoryPictureBox5.Enabled = true;
                inventoryPictureBox5.Image = Expedition.Properties.Resources.potion_red;
            }
            weaponControl.Location = game.WeaponInRoom.Location;
            if (game.WeaponInRoom.PickedUp)
                weaponControl.Visible = false;
            else
                weaponControl.Visible = true;

            if (game.PlayerHitPoints <= 0)
            {
                MessageBox.Show(@"You died");
                Application.Exit();
            }
            if (enemiesShown < 1 && game.Level<8)
            {
                MessageBox.Show(@"You have defeated the enemies on this level");
                game.NewLevel(random);
                UpdateCharacters();
            }
        }

        private void MoveUpButtonClick(object sender, EventArgs e)
        {
            game.Move(Direction.Up, random);
            UpdateCharacters();
        }

        private void MoveDownButtonClick(object sender, EventArgs e)
        {
            game.Move(Direction.Down,random);
            UpdateCharacters();
        }

        private void MoveLeftButtonClick(object sender, EventArgs e)
        {
            game.Move(Direction.Left, random);
            UpdateCharacters();
        }

        private void MoveRightButtonClick(object sender, EventArgs e)
        {
            game.Move(Direction.Right, random);
            UpdateCharacters();
        }

        private void Form1CursorChanged(object sender, EventArgs e)
        {
        }

        private void Form1MouseMove(object sender, MouseEventArgs e)
        {
           
        }

        private void AttackUpButtonClick(object sender, EventArgs e)
        {
            game.Attack(Direction.Up,random);
            UpdateCharacters();
        }

        private void AttackDownButtonClick(object sender, EventArgs e)
        {
            game.Attack(Direction.Down,random);
            UpdateCharacters();
        }

        private void AttackLeftButtonClick(object sender, EventArgs e)
        {
            game.Attack(Direction.Left,random);
            UpdateCharacters();
        }

        private void AttackRightButtonClick(object sender, EventArgs e)
        {
            game.Attack(Direction.Right,random);
            UpdateCharacters();
        }

        private void InventoryPictureBox1Click(object sender, EventArgs e)
        {
            game.Equip("Sword");
            inventoryPictureBox1.BorderStyle=BorderStyle.FixedSingle;
            inventoryPictureBox2.BorderStyle=BorderStyle.None;
            inventoryPictureBox3.BorderStyle = BorderStyle.None;
            inventoryPictureBox4.BorderStyle = BorderStyle.None;
            inventoryPictureBox5.BorderStyle = BorderStyle.None;
        }

        private void InventoryPictureBox2Click(object sender, EventArgs e)
        {
            game.Equip("Bow");
            inventoryPictureBox2.BorderStyle = BorderStyle.FixedSingle;
            inventoryPictureBox1.BorderStyle = BorderStyle.None;
            inventoryPictureBox3.BorderStyle = BorderStyle.None;
            inventoryPictureBox4.BorderStyle = BorderStyle.None;
            inventoryPictureBox5.BorderStyle = BorderStyle.None;
        }

        private void InventoryPictureBox3Click(object sender, EventArgs e)
        {
            game.Equip("Mace");
            inventoryPictureBox3.BorderStyle = BorderStyle.FixedSingle;
            inventoryPictureBox1.BorderStyle = BorderStyle.None;
            inventoryPictureBox2.BorderStyle = BorderStyle.None;
            inventoryPictureBox4.BorderStyle = BorderStyle.None;
            inventoryPictureBox5.BorderStyle = BorderStyle.None;
        }

        private void InventoryPictureBox4Click(object sender, EventArgs e)
        {
            game.Equip("Blue Potion");
            inventoryPictureBox4.BorderStyle = BorderStyle.FixedSingle;
            inventoryPictureBox1.BorderStyle = BorderStyle.None;
            inventoryPictureBox2.BorderStyle = BorderStyle.None;
            inventoryPictureBox3.BorderStyle = BorderStyle.None;
            inventoryPictureBox5.BorderStyle = BorderStyle.None;
        }

        private void InventoryPictureBox5Click(object sender, EventArgs e)
        {
            game.Equip("Red Potion");
            inventoryPictureBox5.BorderStyle = BorderStyle.FixedSingle;
            inventoryPictureBox1.BorderStyle = BorderStyle.None;
            inventoryPictureBox2.BorderStyle = BorderStyle.None;
            inventoryPictureBox3.BorderStyle = BorderStyle.None;
            inventoryPictureBox4.BorderStyle = BorderStyle.None;
        }
    }
}
