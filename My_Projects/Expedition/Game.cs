﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;


namespace Expedition
{
    class Game
    {
        private Player player;
        private int level = 0;
        private Rectangle boundaries;


        public IEnumerable<Enemy> Enemies { get; private set; }
        public Weapon WeaponInRoom { get; private set; }
        public Point PlayerLocation { get { return player.Location; } }
        public int PlayerHitPoints { get { return player.HitPoints; } }
        public IEnumerable<string> PlayerWeapons { get { return player.Weapons; } }
        public int Level { get { return level; } }
        public Rectangle Boundaries { get { return boundaries; } }



        public Game(Rectangle boundaries)
        {
            this.boundaries = boundaries;
            player = new Player(this, new Point(boundaries.Left+10, boundaries.Top+100));
        }

        public void Move(Direction direction, Random random)
        {
            player.Move(direction);
            foreach (Enemy enemy in Enemies)
                enemy.Move(random);
        }

        public void Equip(string weaponName)
        {
            player.Equip(weaponName);
        }

        public bool CheckPlayerInventory(string weaponName)
        {
            return player.Weapons.Contains(weaponName);
        }

        public void HitPlayer(int maxDamage, Random random)
        {
            player.Hit(maxDamage, random);
        }

        public void IncreasePlayerHealth(int health, Random random)
        {
            player.IncreaseHealth(health, random);
        }

        public void Attack(Direction direction, Random random)
        {
            player.Attack(direction, random);

            foreach (Enemy enemy in Enemies)
                enemy.Move(random);
        }

        public void NewLevel(Random random)
        {
            level++;
            switch (level)
            {
                case 1:
                    Enemies = new List<Enemy>() 
                    { 
                        new Bat(this, GetRandomLocation(random))
                    };

                    WeaponInRoom = new Sword(this, GetRandomLocation(random));
                    break;


                case 2:
                    Enemies = new List<Enemy>()
                    {
                        new Ghost(this, GetRandomLocation(random))
                    };

                    WeaponInRoom = new BluePotion(this, GetRandomLocation(random));
                    break;



                case 3:
                    Enemies = new List<Enemy>()
                    {
                        new Ghoul(this, GetRandomLocation(random))
                    };

                    WeaponInRoom = new Bow(this, GetRandomLocation(random));
                    break;



                case 4:
                    Enemies = new List<Enemy>()
                    {
                        new Bat(this, GetRandomLocation(random)),
                        new Ghost(this, GetRandomLocation(random))
                    };
                   
                    if (!CheckPlayerInventory("Bow"))
                    {
                        WeaponInRoom = new Bow(this, GetRandomLocation(random));
                    }
                    else
                    {
                        WeaponInRoom = new BluePotion(this, GetRandomLocation(random));
                    }
                    break;


                case 5:
                    Enemies = new List<Enemy>()
                    {
                        new Bat(this, GetRandomLocation(random)),
                        new Ghoul(this, GetRandomLocation(random))
                    };
                    WeaponInRoom = new RedPotion(this, GetRandomLocation(random));
                    break;


                case 6:
                    Enemies = new List<Enemy>()
                    {
                        new Ghost(this, GetRandomLocation(random)),
                        new Ghoul(this, GetRandomLocation(random))
                    };
                    WeaponInRoom = new Mace(this, GetRandomLocation(random));
                    break;


                case 7:
                    Enemies = new List<Enemy>()
                    {
                        new Bat(this, GetRandomLocation(random)),
                        new Ghost(this, GetRandomLocation(random)),
                        new Ghoul(this,GetRandomLocation(random))
                    };
                    
                    if (!CheckPlayerInventory("Mace"))
                    {
                        WeaponInRoom = new Mace(this, GetRandomLocation(random));
                    }
                    else
                    {
                        WeaponInRoom = new RedPotion(this, GetRandomLocation(random));
                    }
                    break;


                case 8:
                    MessageBox.Show(@"Nice!"+Environment.NewLine+@"You are MASTER now!");
                    Application.Exit();
                    break;

            }
        }

        private Point GetRandomLocation(Random random) 
        {
            return new Point(boundaries.Left + random.Next(boundaries.Right / 10 - boundaries.Left / 10) * 10, boundaries.Top + random.Next(boundaries.Bottom / 10 - boundaries.Top / 10) * 10);
        }
    }
}
