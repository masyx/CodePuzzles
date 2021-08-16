using System;

namespace FindMaxMinValueInArray
{
    class FindMaxMinValueInArrayProgram
    {
        static void Main(string[] args)
        {
            int[] myArrya = { 5, 89, 7, 6, 87, 12, 9, -6 };
            var maxMin = FindMaxMin(myArrya);
            Console.WriteLine($"Max value in the array: {maxMin[1]}");
            Console.WriteLine($"Min value in the array: {maxMin[0]}");
        }

        public static int[] FindMaxMin(int[] numbers)
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

            int[] maxMinValues = { min, max };

            return maxMinValues;
        }
    }
}
