using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DurationParser
{
    internal class TimeDuration
    {
        public int Hour { get; set; } = 0;
        public int Minute { get; set; } = 0;
        public int Second { get; set; } = 0;

        public TimeDuration(int hour, int minute, int second)
        {
            Hour = hour;
            Minute = minute;
            Second = second;
        }

        public TimeDuration(int second)
        {
            Second = second;
        }
        public TimeDuration(int minute, int second)
        {
            Minute = minute;
            Second = second;
        }
    }
}
