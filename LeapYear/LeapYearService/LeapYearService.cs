using System;

namespace LeapYear.Service
{
    public class LeapYearService
    {
        public bool IsLeapYear(int year)
        {
            if (year == 0) throw new ArgumentException("Year zero (0) does NOT exists!");

            return year > 0 && (year % 100 == 0 ? year % 400 == 0 || year < 1582 : year % 4 == 0);
        }
    }
}
