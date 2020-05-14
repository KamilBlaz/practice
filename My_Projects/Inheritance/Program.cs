using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Owner owner = new Owner();
            Safe safe = new Safe();
            Jewels safeContents = new Jewels();
            JewelThief jewelThief = new JewelThief();
            Locksmith calledAsLocksmith = new JewelThief();





            jewelThief.OpenSafe(safe, owner);
            Console.WriteLine("\n");
            jewelThief.ReturnContents(safeContents, owner);
            Console.WriteLine("\n");
            calledAsLocksmith.ReturnContents(safeContents, owner);

            Console.ReadKey();
        }
    }
}
