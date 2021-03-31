using System;

namespace CreditCardChecker
{
    class CreditCardCheckerProgram
    {
        static void Main(string[] args)
        {
            long ccNumber;
            do
            {
                Console.Write("Number: ");
                ccNumber = long.Parse(Console.ReadLine()); 
            }
            while (ccNumber == 0);

            if (checkCreditCardValidity(ccNumber))
            {
                printCreditCardBrand(ccNumber);
            }
            else
            {
                Console.WriteLine("INVALID\n");
            }
        }

        static bool checkCreditCardValidity(long ccNumber)
        {
            int length = findLength(ccNumber);

            return (length == 13 || length == 15 || length == 16) && checksumIsValid(ccNumber);
        }

        static int findLength(long n)
        {
            int length;
            for (length = 0; n != 0; n /= 10, length++) ;
            //for(length = 0; n != 0; n /= 10)
            //{
            //    length++;
            //}

            return length;
        }

        static bool checksumIsValid(long ccNumber)
        {
            int sum = 0;
            int wn;
            long ccNumberWorking = ccNumber;

            while (ccNumberWorking > 0)
            {
                sum += (int)(ccNumberWorking % 10);
                ccNumberWorking /= 100;
            }

            while (ccNumber > 0)
            {
                ccNumber /= 10;
                wn = (int)((ccNumber % 10) * 2);

                if (wn > 9)
                {
                    sum += (wn % 10) + (wn / 10);
                }
                else
                {
                    sum += wn;
                }
                ccNumber /= 10;
            }

            return sum % 10 == 0;
        }

        static void printCreditCardBrand(long ccn)
        {
            if ((ccn >= 34e13 && ccn < 35e13) || (ccn >= 37e13 && ccn < 38e13))
                Console.WriteLine("AMEX\n");
            else if ((ccn >= 51e14 && ccn < 56e14))
                Console.WriteLine("MASTERCARD\n");
            else if ((ccn >= 4e12 && ccn < 5e12) || (ccn >= 4e15 && ccn < 5e15))
                Console.WriteLine("VISA\n");
            else
                Console.WriteLine("INVALID\n");
        }
    }
}
