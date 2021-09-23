﻿using System;
using System.Linq;

namespace FizzBuzz
{
    class FizzBuzz
    {
        public static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.Write("FizzBuzz,");
                }
                else if (i % 3 ==0)
                {
                    Console.Write("Fizz,");
                }
                else if (i % 5 == 0)
                {
                    Console.Write("Buzz,");
                }
                else
                {
                    Console.Write($"{i.ToString()},");
                }
            }

            // OR
            Console.WriteLine();

            for (int i = 1; i <= 100; i++)
            {
                string str = "";
                if (i % 3 == 0)
                {
                    str += "Fizz";
                }
                if(i % 5 == 0)
                {
                    str += "Buzz";
                }
                if (str.Length == 0)
                {
                    str = i.ToString();
                }
                Console.Write(str + ",");
            }


            //OR

            Console.WriteLine();

            var numbers = Enumerable.Range(1, 100);

            foreach(int number in numbers)
            {
                var str = "";
                if(number % 3 == 0)
                {
                    str += "Fizz";
                }
                if (number % 5 == 0)
                {
                    str += "Buzz";
                }
                if (str.Length == 0)
                {
                    str = number.ToString();
                }

                Console.Write(str + ",");
            }
        }

    }
}
