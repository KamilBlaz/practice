using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_exercises_
{
    interface IScaryClown : IClown
    {
        string ScaryThingIhave { get; }
        void ScareLittleChildren();
    }
}
