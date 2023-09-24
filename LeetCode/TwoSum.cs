using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public static class TwoSum
    {
        public static List<int> TwoSumHashMap(List<int> nums, int targetSum)
        {
            Dictionary<int, int> seen = new();
            
            for(int i = 0; i < nums.Count; i++)
            {
                var complement = targetSum - nums[i];
                if (seen.TryGetValue(complement, out int index))
                {
                    return new List<int> { i, index };
                }
                seen[nums[i]] = i;
            }

            return new List<int>();
        }
    }
}
