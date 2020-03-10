using System;
using System.Threading;
using DefaultNamespace;

namespace restaurant_app_backend
{
    public class Booking
    {
        private static int _counter = 1;
        public User User { get; private set; }
        public Restaurant Restaurant { get; private set; }
        public Availability TimeSlot { get; private set; }
        public int Id { get; private set; }

        public Booking(User user, Restaurant restaurant, Availability timeSlot)
        {
            this.User = user;
            this.Restaurant = restaurant;
            this.TimeSlot = timeSlot; 
            this.Id = _counter;
            Interlocked.Add(ref _counter, 1);
        }
    }
}