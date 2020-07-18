
using Notes.Service;
using System;

namespace Notes.UnitTest.Service
{
    class TestClock : IClock
    {
        public DateTime Now()
        {
            return new DateTime(2020, 8, 25);
        }
    }
}
