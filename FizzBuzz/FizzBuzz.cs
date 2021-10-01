using System;
using System.Linq;
using System.Collections.Generic;

namespace FizzBuzz
{
    class FizzBuzz
    {
        public static void Main(string[] args)
        {
            // No.1
            foreach (var item in FizzBuzz1())
            {
                Console.Write(item + ",");
            }

            Console.WriteLine();

            // No.2
            foreach (var item in FizzBuzz2())
            {
                Console.Write(item + ",");
            }

            Console.ReadLine();
        }

        static List<string> FizzBuzz1()
        {
            var result = new List<string>();

            for (int i = 1; i <= 100; i++)
            {
                string str = "";

                if (i % 3 == 0)
                {
                    str += "Fizz";
                }
                if (i % 5 == 0)
                {
                    str += "Buzz";
                }
                if (str.Length == 0)
                {
                    str = i.ToString();
                }
                result.Add(str);
            }
            return result;
        }

        static List<string> FizzBuzz2()
        {
            var result = new List<string>();

            for(int i = 1; i < 101; i++)
            {
                if (i % 15 == 0)
                    result.Add("FizzBuzz");
                else if (i % 3 == 0)
                    result.Add("Fizz");
                else if (i % 5 == 0)
                    result.Add("Buzz");
                else
                    result.Add(i.ToString());
            }
            return result;
        }
    }
}
