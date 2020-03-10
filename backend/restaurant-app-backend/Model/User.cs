using System;
using System.Threading;

namespace DefaultNamespace
{
    public class User
    {
        private static int _counter = 1;
        public int Id { get; private set; }
        public string Name { get; private set; }
        public DateTime DateOfBirth { get; private set; }

        public User(string name, DateTime dateOfBirth)
        {
            this.Name = name;
            this.DateOfBirth = dateOfBirth;
            this.Id = _counter;
            Interlocked.Add(ref _counter, 1);
        }
    }
}