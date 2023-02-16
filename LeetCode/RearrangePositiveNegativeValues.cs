using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class RearrangePositiveNegativeValues
    {
        public static void Rearrange(List<int> collection)
        {
            int lastIdx = 0;
            for (int i = 0; i < collection.Count; i++)
            {
                if (collection[i] < 0)
                {
                    var temp = collection[lastIdx];
                    collection[lastIdx] = collection[i];
                    collection[i] = temp;
                    lastIdx++;
                }
            }
        }
    }
}
