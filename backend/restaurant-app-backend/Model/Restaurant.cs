using System;
using System.Threading;

namespace restaurant_app_backend
{
    public class Restaurant
    {
        private static int _counter = 1;
        public string Name { get; private set; }
        public int Id { get; private set; }

        public Restaurant(string name)
        {
            this.Name = name;
            this.Id = _counter;
            Interlocked.Add(ref _counter, 1);
        }
    }
}
