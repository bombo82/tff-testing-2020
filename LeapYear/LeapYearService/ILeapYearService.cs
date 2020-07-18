using System;

namespace LeapYear.Service
{
    /// <summary>
    /// Given a year returns if it is a leap year.
    /// </summary>
    /// <exception cref="ArgumentException">Thrown when <paramref name="year"> is <c>0</c></exception>
    interface ILeapYearService
    {
        bool IsLeapYear(int year);
    }
}