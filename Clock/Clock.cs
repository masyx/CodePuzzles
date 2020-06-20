using System;

namespace Clock
{
    class Clock
    {
        //Clock shows 'h' hours, 'm' minutes and 's' seconds after midnight.
        //Your task is to make 'Past' function which returns time converted to milliseconds.
        //Example:
        //Past(0, 1, 1) == 61000
        //Input constraints: 0 <= h <= 23, 0 <= m <= 59, 0 <= s <= 59

        static void Main(string[] args)
        {
            Console.WriteLine(Past(1,1,1));
        }

        public static int Past(int h, int m, int s)
        {
            var interval = new TimeSpan(h,m,s);
            return (int)interval.TotalMilliseconds;
        }
    }
}
