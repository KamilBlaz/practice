using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Expedition
{
    class Ghoul:Enemy
    {
        public Ghoul(Game game, Point location) : base(game, location, 10)
        {
            
        }

        public override void Move(Random random)
        {
           
            if (HitPoints>0)
            {
                var action = random.Next(1, 4);
                switch (action)
                {
                    case 1:
                        break;

                    case 2:
                    case 3:
                        Direction moveDirection = FindPlayerDirection(Game.PlayerLocation);
                        this.location = this.Move(moveDirection, Game.Boundaries);
                        break;
                }
            }

            if (NearPlayer() && !Dead)
                Game.HitPlayer(4, random);
        }
    }
}
