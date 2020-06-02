using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorsMVVM.Model
{
    static class ColorSettings
    {
        public static ColorModel readColor()
        {
            Properties.Settings properties = Properties.Settings.Default;
            return new ColorModel(properties.R, properties.G, properties.B);
        }
        public static void saveColor(ColorModel model)
        {
            Properties.Settings properties = Properties.Settings.Default;
            properties.R = model.R;
            properties.G = model.G;
            properties.B = model.B;
            properties.Save();
        }

    }
}
