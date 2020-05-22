using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Expedition
{
    class BluePotion:Weapon, IPotion
    {
        public override string Name
        {
            get { return "Blue Potion"; }
        }

        public bool Used { get; private set; }



        public BluePotion(Game game, Point location) : base(game, location)
        {
            Used = false;
        }
      
        public override void Attack(Direction direction, Random random)
        {
            if (!Used)
            {
                this.Game.IncreasePlayerHealth(5, random);
                Used = true;
            }
        }

       
    }
}
