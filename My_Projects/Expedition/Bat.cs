using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Expedition
{
    class Bat:Enemy
    {
       
        public Bat(Game game, Point location) : base(game, location, 6)
        {}

         public override void Move(Random random)
         {
              
             Direction moveDirection;

             if (this.HitPoints >= 1) 
             {
                 moveDirection = FindPlayerDirection(Game.PlayerLocation);
                 this.location=this.Move(moveDirection, Game.Boundaries);
                 
             }
             else
             {
                 moveDirection = (Direction)random.Next(0, 5);
                 this.location=this.Move(moveDirection, Game.Boundaries);
             }

             if (NearPlayer() && !Dead)
             {
                Game.HitPlayer(2,random); 
             }

         }
    }
}
