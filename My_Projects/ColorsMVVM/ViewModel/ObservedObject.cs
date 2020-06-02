using System.ComponentModel;

public abstract class ObservedObject : INotifyPropertyChanged

{
    public event PropertyChangedEventHandler PropertyChanged;

    protected void onPropertyChanged(params string[] propertiesNames)
    {
        if(PropertyChanged != null)
        {
            foreach (string names in propertiesNames)
                PropertyChanged(this, new PropertyChangedEventArgs(names));
        }
    }

}

