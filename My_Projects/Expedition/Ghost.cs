using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Expedition
{
    class Ghost:Enemy
    {
        public Ghost(Game game, Point location) : base(game, location, 6)
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
                        Direction moveDirection = FindPlayerDirection(Game.PlayerLocation);
                        this.location=this.Move(moveDirection, Game.Boundaries);
                        break;

                    case 2:
                    case 3:
                    break;
                }
            }

            if(NearPlayer() && !Dead)
                Game.HitPlayer(3, random);
            
        }
    }
}
