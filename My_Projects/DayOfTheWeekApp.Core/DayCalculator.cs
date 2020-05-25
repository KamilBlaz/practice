﻿using DayOfTheWeekApp.Core.Enums;
using System;
using System.Collections.Generic;

namespace DayOfTheWeekApp.Core
{
    public class DayCalculator
    {
        public DayOfTheWeek CalculateDayOfTheWeek(DateTimeOffset date)
        {
            var day = date.Day;
            var month = date.Month;
            var year = date.Year;
            var listOfParamteres = new List<int> { 0, 3, 2, 5, 0, 3, 5, 1, 4, 6, 2, 4 };

            year -= month < 3 ? 1 : 0;
            var calculateValue = (year + year / 4 - year / 100 + year / 400 - listOfParamteres[month - 1] + day) % 7;

            return (DayOfTheWeek)(calculateValue - 1);
        }
    }
}
