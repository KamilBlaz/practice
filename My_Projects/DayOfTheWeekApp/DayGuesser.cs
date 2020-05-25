using DayOfTheWeekApp.Core;
using DayOfTheWeekApp.Core.Enums;
using System;

namespace DayOfTheWeekApp
{
     public class DayGuesser
    {
        public DayCalculator Calculator { get; set; }
        public DayOfTheWeek UserDayOfTheWeek { get; set; }
        public DateTimeOffset UserDateOfBrith { get; set; }

        public void IntroducesTheApplication()
        {
            Console.WriteLine("WELCOME IN APP");

            Calculator = new DayCalculator();
        }

        public void AskUserforTHeirDateOfBrith()
        {
            Console.WriteLine("Podaj mi prosze swoja date urodzina");
           var userDate = Console.ReadLine();
           var succeded = DateTimeOffset.TryParse( userDate, out var date);
            if (succeded)
            {
                UserDateOfBrith = date;
                return;
            }
            Console.WriteLine("Format daty byl zly.Prosze podac go w mm/dd/yyyy");
            AskUserforTHeirDateOfBrith();



        }

        public void CalculateTheDateOfWeek()
        {
            if(UserDateOfBrith == null)
            {
                Console.WriteLine("Probowano obliczyc dzien tygodnia bez podania daty urodenia");
            }
           UserDayOfTheWeek = Calculator.CalculateDayOfTheWeek(UserDateOfBrith);
        }

        public void PrintDayOfTheWeek()
        {
            Console.WriteLine("Obliczony dzien tygodnia to " + UserDayOfTheWeek);
        }
    }
}
