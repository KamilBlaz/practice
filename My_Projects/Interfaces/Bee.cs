using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Bee:IStingPatrol
    {
      public  int AlterLevel { get { return 5; } }
      public  int StingerLength { get; set; }
      public bool LookForEnemies() {
            return true;
                }

      public   int SharpenStinger(int Length) {
            
            return Length;
        }
    }
}
