using System;
using restaurant_app_backend.Model;

namespace restaurant_app_backend
{
    public class Availability
    {
        public DateTime Date { get; private set; }
        public TimeSpan StartTime { get; private set; }
        public TimeSpan FinishTime { get; private set; }

        public Availability(DateTime dateTime, TimeSpan startTime, TimeSpan finishTime)
        {
            this.Date = dateTime.Date;
            this.StartTime = startTime;
            this.FinishTime = finishTime;
        }
    }
}