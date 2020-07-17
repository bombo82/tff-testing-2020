using System;

namespace LeapYear.Service
{
    public class LeapYearService
    {
        public bool IsLeapYear(int year)
        {
            if (year == 0)
                throw new ArgumentException("Year zero (0) does NOT exists!");

            if (year <= 0)
                return false;
            
            if (year % 100 == 0)
                return year % 400 == 0 || year < 1582;
                
            return year % 4 == 0;
        }
    }
}
