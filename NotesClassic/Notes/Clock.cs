using System;

namespace Notes.Clock
{
    class Clock : IClock
    {
        public DateTime Now()
        {
            return DateTime.Now;
        }
    }
}
