using System;

namespace Notes.Service
{
    internal class Clock : IClock
    {
        public DateTime Now()
        {
            return DateTime.Now;
        }
    }
}