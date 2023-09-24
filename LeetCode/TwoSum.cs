using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LeetCode
{
    //Given an array of integers nums and an integer target, return indices
    //of the two numbers such that they add up to target.
    //You may assume that each input would have exactly one solution,
    //and you may not use the same element twice.
    //You can return the answer in any order.
    public static class TwoSum
    {
        public static List<int> TwoSumHashMap(List<int> nums, int targetSum)
        {
            Dictionary<int, int> seenNums = new();
            List<int> result = new();
            
            for(int i = 0; i < nums.Count; i++)
            {
                var complement = targetSum - nums[i];
                if (seenNums.ContainsKey(complement))
                {
                    result.AddRange(new[] { i, seenNums[complement] });
                    return result;
                }
                seenNums[nums[i]] = i;
            }

            return result;
        }
    }
}
