using System;

namespace RomanToArabic
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter Roman number:");
                Console.WriteLine($"Arabic Numner: {RomanToInt(Console.ReadLine())}");
            }
        }

        public static int RomanToInt(string romanNumber)
        {
            int total = 0;
            romanNumber = romanNumber.ToUpper();

            for (int i = 0; i < romanNumber.Length; i++)
            {
                if (i != romanNumber.Length - 1
                    && GetRomanValue(romanNumber[i + 1]) > GetRomanValue(romanNumber[i]))
                {
                    total += GetRomanValue(romanNumber[i + 1]) - GetRomanValue(romanNumber[i]);
                    i++;
                }
                else
                {
                    total += GetRomanValue(romanNumber[i]);
                }
            }

            return total;
        }

        public static int GetRomanValue(char val)
        {
            return val switch
            {
                'I' => 1,
                'V' => 5,
                'X' => 10,
                'L' => 50,
                'C' => 100,
                'D' => 500,
                'M' => 1000,
                _ => 0,
            };
        }
    }
}