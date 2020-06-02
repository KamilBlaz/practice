using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorsMVVM.Model
{
     public class ColorModel
    {
        public byte R, G, B;

        public ColorModel(byte r,byte g, byte b)
        {
            this.R = r;
            this.G = g;
            this.B = b;
        }

    }
}
