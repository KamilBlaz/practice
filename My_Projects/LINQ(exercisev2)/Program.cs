using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace LINQ_exercisev2_
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<Comic> comics = BuildCatalog();
            Dictionary<int, decimal> values = GetPrices();

            var mostExpensive =
                from comic in comics
                where values[comic.Issue] > 500
                orderby values[comic.Issue] descending
                select comic;

            foreach (Comic comic in mostExpensive)
                Console.WriteLine("{0} jest warty {1:c}", comic.Name, values[comic.Issue]);
        }

        private static IEnumerable<Comic> BuildCatalog()
        {
            return new List<Comic>
            {
                new Comic{ Name = "Johnny America vs. the Pinko", Issue = 6},
                new Comic{ Name = "Rock and Roll", Issue = 19},
                new Comic{ Name = "Woman's Work", Issue = 36},
                new Comic{ Name = "Hippie Madness ", Issue = 57},
                new Comic{ Name = "Tribal Tatto Madness", Issue = 83},
                new Comic{ Name = "The Death of an Object", Issue = 97},
            };
        }

        private static Dictionary<int, decimal> GetPrices()
        {
            return new Dictionary<int, decimal>
            {
                {6,3600M },
                {19,500M },
                {36,650M },
                {57,1352M },
                {83,25.75M },
                {97,35.25M },

            };



        }
    }
}
