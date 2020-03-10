﻿using System.Collections.Generic;
using System.Threading;

namespace restaurant_app_backend.Model
{
    public class Table
    {
        private static int _counter = 0;
        public int MinGuests;
        public int MaxGuests;
        public int Id;
        public List<Availability> AvailabilityList;

        public Table(int minGuests, int maxGuests, List<Availability> availabilityList)
        {
            this.MinGuests = minGuests;
            this.MaxGuests = maxGuests;
            this.Id = _counter;
            Interlocked.Add(ref _counter, 1);
            this.AvailabilityList = availabilityList;
        }
    }
}