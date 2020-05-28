using System;
using System.Linq;

namespace LINQ_exercise_
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] values = new int[] { 0, 12, 44, 36, 92, 54, 13, 8 };

            var result = from v in values
                         where v < 37
                         orderby v
                         select v;
            foreach (int i in result)

            Console.WriteLine(i);

            Console.ReadKey();
        }
    }
}
