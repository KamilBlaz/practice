using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Notifications;

namespace Invaders.Model
{
    class ShotMovedEventArgs:EventArgs
    {
        public Shot Shot { get; private set; }
        public bool Disappeared { get; private set; }

        public ShotMovedEventArgs(Shot shot, bool disappeared)
        {
            Shot = shot;
            Disappeared = disappeared;
        }


    }
}
