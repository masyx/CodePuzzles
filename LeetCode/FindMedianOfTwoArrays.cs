using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class FindMedianOfTwoArrays
    {
        // O(n) time | O(n + m) space
        public static double MedianOfTwoArrays(int[] arr1, int[] arr2)
        {
            if (arr1.Length == 0 && arr2.Length == 0)
                throw new ArgumentException("Both arrays are empty.");

            var merged = new int[arr1.Length + arr2.Length];
            int k = 0, i = 0, j = 0;
            while (i != arr1.Length || j != arr2.Length)
            {
                if (j == arr2.Length || (i < arr1.Length && arr1[i] < arr2[j]))
                {
                    merged[k++] = arr1[i++];
                }
                else
                {
                    merged[k++] = arr2[j++];
                }
            }
            int medianIdx = (merged.Length - 1) / 2;
            if(merged.Length % 2 == 0)
            {
                return (merged[medianIdx] + merged[medianIdx + 1]) / 2.0;
            }
            else
            {
                return merged[medianIdx];
            }
        }
    }
}
