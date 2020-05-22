﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Expedition
{
    class RedPotion:Weapon, IPotion
    {


        public bool Used { get; private set; }

        public override string Name
        {
            get { return "Red Potion"; }
        }




        public RedPotion(Game game, Point location) : base(game, location)
        {
            Used = false;
        }
                
        public override void Attack(Direction direction, Random random)
        {
            if (!Used)
            {
                this.Game.IncreasePlayerHealth(10, random);
                Used = true;
            }
        }

    }
}
