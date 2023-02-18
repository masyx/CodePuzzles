using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public static class MaxSubarray
    {
        // O(n^2) time | O(1) space
        public static int MaxSubarrayValue_BruteForce(List<int> lst)
        {
            if (lst is null || !lst.Any())
                throw new ArgumentException("List cannot be empty");
            if (lst.Count == 1)
                return lst[0];

            int maxSum = int.MinValue;
            for (int i = 0; i < lst.Count; i++)
            {
                var currentSum = lst[i];
                for (int j = i + 1; j < lst.Count; j++)
                {
                    currentSum += lst[j];
                    maxSum = Math.Max(maxSum, currentSum);
                }
            }
            return maxSum;
        }

        // O(n) time | O(1) space
        public static int MaxSubArrayKadanesAlg(List<int> lst)
        {
            if (lst == null || lst.Count == 0)
                throw new ArgumentException("List cannot be empty");
            if (lst.Count == 1)
                return lst[0];

            var currMax = lst[0];
            var globalMax = lst[0];
            for (int i = 1; i < lst.Count; i++)
            {
                if (currMax < 0)
                    currMax = lst[i];
                else
                    currMax += lst[i];
                globalMax = Math.Max(currMax, globalMax);
            }

            return globalMax;
        }
    }
}
