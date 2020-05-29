using System;
using System.Collections.Generic;
using System.Text;

namespace Delagtesv2
{
    class SomeLongRunnningData
    {
        public delegate void CallBack(int i);

        public void SomeMethod(CallBack obj)
        {
            for(int i = 0; i < 1000; i++)
            {
                obj(i);
                // robi sie cos w tle
            }
        }
    }
}
