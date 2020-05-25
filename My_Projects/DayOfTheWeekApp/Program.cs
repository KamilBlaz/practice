using System;

namespace DayOfTheWeekApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var guesser = new DayGuesser();
            guesser.IntroducesTheApplication();
            guesser.AskUserforTHeirDateOfBrith();
            guesser.CalculateTheDateOfWeek();
            guesser.PrintDayOfTheWeek();
        }
    }
}
