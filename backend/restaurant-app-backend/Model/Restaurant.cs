using System;
using System.Collections.Generic;
using System.Threading;
using restaurant_app_backend.Model;

namespace restaurant_app_backend
{
    public class Restaurant
    {
        private static int _counter = 1;
        public string Name { get; private set; }
        public int Id { get; private set; }
        public List<Table> TableList { get; private set; }

        public Restaurant(string name, List<Table> tableList)
        {
            this.Name = name;
            this.Id = _counter;
            Interlocked.Add(ref _counter, 1);
            this.TableList = tableList;
        }
    }
}
