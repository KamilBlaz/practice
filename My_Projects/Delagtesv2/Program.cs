using System;

namespace Delagtesv2
{
    class Program
    {
        static void Main(string[] args)
        {
            SomeLongRunnningData sm = new SomeLongRunnningData();
            sm.SomeMethod(CallBackMethod);
            Console.ReadKey();
        }

        static void CallBackMethod(int i)
        {
            Console.WriteLine(i);
        }
    }
}
