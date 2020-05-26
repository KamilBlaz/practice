using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Devices.Input;

namespace messyJanek_XAML_
{
    public class MenuMaker
    {

        private Random random = new Random();
        private List<String> meats = new List<String>()
              {"Pieczona wołowina", "Salami", "indyk", "Szynka", "Karkówka"};

        private List<String> condiments = new List<String>() {"żółta musztarda",
        "brązowa musztarda", "musztarda miodowa", "majonez", "przyprawa", "sos francuski" };

        private List<String> breads = new List<String>() {"żółta musztarda",
        "brązowa musztarda", "musztarda miodowa", "majonez", "przyprawa", "sos francuski" };

        public ObservableCollection<MenuItem> Menu { get; private set; }
        public DateTime GeneratedDate { get; private set; }
        public int NumberOfItems { get; set; }

        public MenuMaker(){
            Menu = new ObservableCollection<MenuItem>();
            NumberOfItems = 10;
            UpdateMenu();
        }

        private MenuItem CreateMenuItem(){
            string randomMeat = meats[random.Next(meats.Count)];
            string randomCondiment = condiments[random.Next(condiments.Count)];
            string randomBreads = breads[random.Next(breads.Count)];
            return new MenuItem(randomMeat, randomCondiment, randomBreads);
        }
        public void UpdateMenu(){
            Menu.Clear();
            for(int i = 0; i < NumberOfItems; i++){
                Menu.Add(CreateMenuItem());
            }
            GeneratedDate = DateTime.Now;

        }
    }
}
