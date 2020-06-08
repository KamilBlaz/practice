using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invaders.Model
{
    class StarChangedEventArgs:EventArgs

    {
        public Point Point { get; private set; }
        public bool Disapperated { get; private set; }

        public StarChangedEventArgs(Point point, bool disappeared){
            Point = point;
            Disapperated = disappeared;

        }

    }
}
