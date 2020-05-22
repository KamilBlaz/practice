using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Expedition
{
    class Player : Mover
    {
        private Weapon equippedWeapon;

        public int HitPoints { get; private set; }
        private List<Weapon> inventory = new List<Weapon>();
        public IEnumerable<string> Weapons
        {
            get
            {
                List<string> names = new List<string>();
                foreach (Weapon weapon in inventory)
                    names.Add(weapon.Name);
                return names;
            }
        }


        public Player(Game game, Point location): base(game, location)
        {
            HitPoints = 10;
        }

        public void Hit(int maxDamage, Random random)
        {
            HitPoints -= random.Next(1, maxDamage);
        }

        public void IncreaseHealth(int health, Random random)
        {
            HitPoints += random.Next(1, health);
        }

        public void Equip(string weaponName)
        {
            foreach (Weapon weapon in inventory)
            {
                if (weapon.Name == weaponName)
                    equippedWeapon = weapon;
            }
        }

        public void Move(Direction direction)
        {
            location = Move(direction, Game.Boundaries);
            if (!Game.WeaponInRoom.PickedUp)
            {
                
                if (Nearby(Game.WeaponInRoom.Location, 25))
                {
                    inventory.Add(Game.WeaponInRoom);
                    Game.WeaponInRoom.PickUpWeapon();
                }
            }
        }

        public void Attack(Direction direction, Random random)
        {
            
            try
            {
                equippedWeapon.Attack(direction, random);

                if (equippedWeapon is IPotion)
                {
                    inventory.Remove(equippedWeapon);
                    equippedWeapon = null;
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Select a weapon ", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
