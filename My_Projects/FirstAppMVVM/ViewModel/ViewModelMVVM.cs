using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace FirstAppMVVM.ViewModel
{
    using Model;
    public class ViewModelMVVM: INotifyPropertyChanged
    {
        private ModelMVVM model = new ModelMVVM();
        public double Value
        {
            get
            {
                return model.Value;
            }
            set
            {
                model.Value = value;
                onPropertyChanged(nameof(Value));

            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void onPropertyChanged(string nameProperties)
        {
            if (PropertyChanged != null)
            PropertyChanged(this, new PropertyChangedEventArgs(nameProperties));

        }
    }
}
