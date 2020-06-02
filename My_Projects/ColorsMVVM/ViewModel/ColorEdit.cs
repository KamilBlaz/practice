using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ColorsMVVM.ViewModel
{
    using Model;
    using System.Windows.Media;

    public  class ColorEdit:ObservedObject
    {

        private readonly ColorModel model = ColorSettings.readColor();

        public byte R
        {
            get
            {
                return model.R;
            }
            set
            {
                model.R = value;
                onPropertyChanged(nameof(R), nameof(color));
            }
        }
        public byte G
        {
            get
            {
                return model.G;
            }
            set
            {
                model.G = value;
                onPropertyChanged(nameof(G), nameof(color));
            }
        }


        public byte B
        {
            get
            {
                return model.B;
            }
            set
            {
                model.B = value;
                onPropertyChanged(nameof(B), nameof(color));
            }
        }

        public Color color 
        {
            get
            {
                return Color.FromRgb(model.R, model.G, model.B);
            }
        }

        public void saveViewModel()
        {
            ColorSettings.saveColor(model);
        }










    }
}
