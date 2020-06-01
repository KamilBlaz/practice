using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Imaging;

namespace FixAppJanek
{
    class ComicQueryManager
    {
        public ObservableCollection<ComicQuery> AvailableQueries { get; private set; }

        public ObservableCollection<object> CurrentQueryResults { get; private set; }
        public string Title { get; set; }

        public ComicQueryManager(){
            UpdateAvailableQueries();
            CurrentQueryResults = new ObservableCollection<object>();

        }

        private void UpdateAvailableQueries()
        {
            AvailableQueries = new ObservableCollection<ComicQuery>{
                new ComicQuery(" LINQ ułatwia zapytania"," Proste zapytanie",
                "Pokazmy Jankowi jak elastyczna jest technologia LINQ",
                CreateImageFromAssets("Captain_amazing_250x250.jpg")),

            };
        }

        private static BitmapImage CreateImageFromAssets(string imageFilename){
            return new BitmapImage(new Uri("ms-appx:///Assets/" + imageFilename));
        }

        public void UpdateQueryResults(ComicQuery query){
            Title = query.Title;
            switch (query.Title)
            {
                case " LINQ ułatwia zapytania": LinqMakesQuieriesEasy(); break;
                case "Drogie komiksy": ExpensiveComics(); break;
            }

        }

        private void ExpensiveComics()
        {
            IEnumerable<Comic> comics = BuildCatalog();
            Dictionary<int, decimal> values = GetPrices();

            var mostExpensive = from comic in comics
                                where values[comic.Issue] > 500
                                orderby values[comic.Issue] descending
                                select comic;

            foreach (Comic comic in mostExpensive)
                CurrentQueryResults.Add(
                    new
                    {
                        Title = String.Format("{0} jest warty {1:c",
                                        comic.Name, values[comic.Issue]),
                        Image = CreateImageFromAssets("captain_amazing_250x250.jpg"),
                    }
                    );
        }

        private void LinqMakesQuieriesEasy()
        {
            int[] values = new int[] { 0, 12, 44, 36, 92, 54, 13, 8 };
            var result = from v in values
                         where v < 37
                         orderby v
                         select v;

            foreach (int i in result)
                CurrentQueryResults.Add(
                    new
                    {
                        Title = i.ToString(),
                        Image = CreateImageFromAssets("purple_250x250.jpg"),
                    }
                    );
        }

        public static IEnumerable<Comic> BuildCatalog()
        {
            return new List<Comic> {
            new Comic { Name = "Johny America vs the Pinko", Issue = 6 },
             new Comic { Name = "Rock and Roll (edycja limitowana)", Issue = 19 },
             new Comic { Name = "Woman's Work", Issue = 36 },
             new Comic { Name = "Johny America vs the Pinko", Issue = 6 },
             new Comic { Name = "Johny America vs the Pinko", Issue = 6 },
             new Comic { Name = "Johny America vs the Pinko", Issue = 6 },
             };

        }

        private static Dictionary<int,decimal> GetPrices()
        {
            return new Dictionary<int, decimal>
            {
                {6,360M },{19,500M },{36,650M },{57,1352M },
                {68,250M },{74,75M },{83,25.75M },{97,35.250M },
            };
        }
    }
}
