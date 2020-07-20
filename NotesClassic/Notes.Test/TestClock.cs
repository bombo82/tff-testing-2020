using Notes.Clock;
using System;

namespace Notes.UnitTest.Service
{
    internal class TestClock : IClock
    {
        public DateTime Now()
        {
            return new DateTime(2000, 12, 25);
        }
    }
}