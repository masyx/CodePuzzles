using System;

namespace TwoSum
{
    class TwoSum
    {
        public static void Main(string[] args)
        {
            var result = TwoSumBruteForce(new int[] { 2, 11, 7, 15 }, 9);
            Console.WriteLine($"{result[0]}, {result[1]}");
        }

        public static int[] TwoSumBruteForce(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                        return new int[] { i, j };
                    
                }
            }
            throw new ArgumentNullException("No two sum solution");
        }
    }
}
