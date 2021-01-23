using System;

namespace IsIntegerPolindrom
{
    class IsIntegerPolindrom
    {
        static void Main(string[] args)
        {
            IsIntegerPolindromMethod(16561);
        }

        static bool IsIntegerPolindromMethod(int x)
        {
            int reversedNumber = 0;
            int originalNumber = x;

            while (x > 0)
            {
                int remainder = x % 10;
                reversedNumber = (reversedNumber * 10) + remainder;
                x /= 10;
            }

            if(originalNumber == reversedNumber)
            {
                Console.WriteLine($"{originalNumber} is a polindrom");
                return true;                
            }
            else
            {
                Console.WriteLine($"{originalNumber} is not a polindrom");
                return false;   
            }
            
        }
    }
}
