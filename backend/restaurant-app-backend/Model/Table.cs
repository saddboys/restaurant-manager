using System.Threading;

namespace restaurant_app_backend.Model
{
    public class Table
    {
        private static int _counter = 0;
        public int MinGuests;
        public int MaxGuests;
        public int Id;

        public Table(int minGuests, int maxGuests)
        {
            this.MinGuests = minGuests;
            this.MaxGuests = maxGuests;
            this.Id = _counter;
            Interlocked.Add(ref _counter, 1);
        }
    }
}