using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public static class RearrangeMaxMin
    {
        public static List<int> RearrangeToMaxMin(List<int> list)
        {
            if (list.Count == 0)
                return list;

            var result = new List<int>(list.Count);
            var start = 0;
            var end = list.Count - 1;
            while(start < end)
            {
                result.Add(list[end--]);
                result.Add(list[start++]);
            }

            if (list.Count % 2 == 1)
                result.Add(list[(list.Count - 1) / 2]);

            return result;
        }
    }
}
