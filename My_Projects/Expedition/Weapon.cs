using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Expedition
{
    abstract class Weapon:Mover
    {
        public bool PickedUp { get ; private set; }
        public abstract string Name { get; }

        public Weapon(Game game, Point location): base(game, location)
        {
            PickedUp = false;
        }

        public void PickUpWeapon()
        {
            PickedUp = true;
        }
        
       
        public abstract void Attack(Direction direction, Random random);

        
        protected bool DamageEnemy(Direction direction, int radius, int damage, Random random) 
        {
            Point target = Game.PlayerLocation;
            for (var distance = 0; distance < radius; distance++)
            {
                foreach (Enemy enemy in Game.Enemies)
                {
                    if (Nearby(enemy.Location, target, distance))
                    {
                        enemy.Hit(damage, random);
                        return true;
                    }
                }
                target = Move(direction, target, Game.Boundaries);
            }
            return false;
        }

       
        public bool Nearby(Point a, Point b, int distance)
        {
            return Math.Abs(a.X - b.X) < distance && (Math.Abs(a.Y - b.Y) < distance);
        }

        public Point Move(Direction direction, Point locationToMove, Rectangle boundaries)
        {
            location = locationToMove;
            return Move(direction, boundaries);          
        }
    }
}
