using System;
using System.Collections.Generic;

namespace restaurant_app_backend
{
    public static class Time
    {
        public static readonly Dictionary<string, TimeSpan> MAP = new Dictionary<string, TimeSpan>()
        {
            {"9am", new TimeSpan(9, 0, 0)},
            {"10am", new TimeSpan(10, 0, 0)},
            {"11am", new TimeSpan(11, 0, 0)},
            {"12pm", new TimeSpan(12, 0, 0)},
            {"1pm", new TimeSpan(1, 0, 0)},
            {"2pm", new TimeSpan(2, 0, 0)},
            {"3pm", new TimeSpan(3, 0, 0)},
            {"4pm", new TimeSpan(4, 0, 0)},
            {"5pm", new TimeSpan(5, 0, 0)},
            {"6pm", new TimeSpan(6, 0, 0)},
            {"7pm", new TimeSpan(7, 0, 0)},
            {"8pm", new TimeSpan(8, 0, 0)},
            {"9pm", new TimeSpan(9, 0, 0)}
        };
    }
}