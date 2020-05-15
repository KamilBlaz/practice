using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiveManagement
{
    class Bee
    {
        public const double HoneyUnitConsumedPerMg = .25;

        public double WeightMg { get; private set; }
        public Bee(double weightMg){
            WeightMg = weightMg;
        }

        virtual public double HoneyConsumptonRate(){
            return WeightMg * HoneyUnitConsumedPerMg;

        }
    }
}
