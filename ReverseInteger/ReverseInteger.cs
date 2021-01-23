using System;

namespace ReverseInteger
{
    class ReverseInteger
    {
        static void Main(string[] args)
        {
            // int.MaxValue = 2147483647
            // 7463847412 
            Console.WriteLine(ReverseIntegerMethod(-1126087180));
        }

        private static int ReverseIntegerMethod(int x)
        {
            long reversedInt = 0;
            bool negative = x < 0;
            if (negative)
            {
                x *= -1;
            }

            while (x > 0)
            {
                int remainder = x % 10;
                reversedInt = (reversedInt * 10) + remainder;
                x /= 10;
            }

            if (negative)
            {
                reversedInt *= -1;
            }

            //return (int)reversedInt; // this return statement doesn't throw an
            // exveption but returns -1126087180

            return reversedInt >= int.MaxValue ? 0 : (int)reversedInt;
        }
    }
}
