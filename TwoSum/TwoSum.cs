using System;

namespace TwoSum
{
    class TwoSum
    {
        public static void Main(string[] args)
        {
            int[] randomArray = new int[111];
            for (int i = 0; i < randomArray.Length; i++)
            {
                var number = new Random().Next(1, 101);
                randomArray[i] = number;
            }


            //var result = TwoSumBruteForce(new int[] { 2, 11, 7, 15 }, 9);
            int target1 = 54;
            var result = TwoSumBruteForce(randomArray, target1);
            Console.WriteLine($"{target1} is the sum of {result[0]} and {result[1]}");

            int target2 = 87;
            var result2 = TwoSumReturnTuple(randomArray, target2);
            Console.WriteLine($"{target2} is the sum of {result2.number1} and {result2.number2}");
        }

        public static int[] TwoSumBruteForce(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new int[] { nums[i], nums[j]};
                    }
                }
            }

            throw new ArgumentException("No two sum solution found");
        }

        public static (int number1, int number2) TwoSumReturnTuple(int[] arrayOfNumbers, int target)
        {
            for (int i = 0; i < arrayOfNumbers.Length; i++)
            {
                for (int j = 1; j < arrayOfNumbers.Length; j++)
                {
                    if (arrayOfNumbers[i] + arrayOfNumbers[j] == target)
                    {
                        return (arrayOfNumbers[i], arrayOfNumbers[j]);
                    }
                }
            }

            throw new ArgumentException("No two sum solution found");
        }
    }
}
