using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invaders.Model
{
    using Windows.Foundation;
    class Shot
    {

        public const double ShotPixelsPerSecond = 95;
        public Point Location { get; private set; }

        private Direction _direction;
        public Direction Direction { get; private set; }

        private DateTime _lastMoved;

        public Shot(Point location, Direction direction){
            Location = location;
            _direction = direction;
            _lastMoved = DateTime.Now;
        }

        public void Move(){
            TimeSpan timeSinceLatMoved = DateTime.Now - _lastMoved;
            double distance = timeSinceLatMoved.Milliseconds * ShotPixelsPerSecond / 1000;
            if (Direction == Direction.Up) distance *= -1;
            Location = new Point(Location.X, Location.Y + distance);
            _lastMoved = DateTime.Now;
        }

    }
}
