using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Test
{
    [TestFixture]
    internal class TwoSumTest
    {
        [Test]
        public void TwoSumTestHappyPath()
        {
            var list = new List<int> { 4, 5, 2, 10 };
            var result = TwoSum.TwoSumHashMap(list, 12);
            Assert.AreEqual(3, result[0]);
            Assert.AreEqual(2, result[1]);
        }

        [Test]
        public void TwoSumTestNoSuchNumbers()
        {
            var list = new List<int> { 4, 5, 2, 10 };
            var result = TwoSum.TwoSumHashMap(list, 13);
            Assert.AreEqual(0, result.Count);
        }

        [Test]
        public void TwoSumMultiplePairs()
        {
            var nums = new List<int> { 1, 1, 2, 3, 3, 4, 4, 4, };
            var result = TwoSum.TwoSumHashMap(nums, 6);
            Assert.AreEqual(4, result[0]);
            Assert.AreEqual(3, result[1]);
        }

        [Test]
        public void TwoSumEmptyList()
        {
            List<int> nums = new();
            var result = TwoSum.TwoSumHashMap(nums, 8);
            Assert.AreEqual(0, result.Count);
        }

        [Test]
        public void TwoSumListWithOneElement()
        {
            var nums = new List<int> { 1 };
            var result = TwoSum.TwoSumHashMap(nums, 99);
            Assert.AreEqual(0, result.Count);
        }
    }
}
