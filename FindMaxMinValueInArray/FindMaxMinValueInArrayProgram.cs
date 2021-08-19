using System;

namespace FindMaxMinValueInArray
{
    class FindMaxMinValueInArrayProgram
    {
        static void Main(string[] args)
        {
            int[] myArrya = { 5, 89, 7, 6, 87, 12, 9, -6 };
            var limits = FindMaxMin(myArrya);
            Console.WriteLine($"Max value in the array: {limits.min}");
            Console.WriteLine($"Min value in the array: {limits.max}");
        }

        public static (int min, int max) FindMaxMin(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                throw new ArgumentException("Cannot operate on empty array");
            }

            int max = int.MinValue;
            int min = int.MaxValue;

            foreach (var i in numbers)
            {
                if (i < min)
                {
                    min = i;
                }
                if (i > max)
                {
                    max = i;
                }
            }

            return (min, max);
        }
    }
}
