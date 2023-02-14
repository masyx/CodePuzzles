using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace LeetCode.Test
{
    [TestFixture]
    internal class FindMedianOfTwoArraysTest
    {
        [Test]
        public void FindMedianOfTwoArraysTest_1()
        {
            var arr1 = new int[] { 1, 2, 3};
            var arr2 = new int[] { 4 };

            var median = FindMedianOfTwoArrays.MedianOfTwoArrays(arr1, arr2);

            Assert.AreEqual(2.5, median);
        }

        [Test]
        public void FindMedianOfTwoArraysTest_2()
        {
            var arr1 = new int[] { 1, 2, 3 };
            var arr2 = new int[] { 4, 5};

            var median = FindMedianOfTwoArrays.MedianOfTwoArrays(arr1, arr2);

            Assert.AreEqual(3, median);
        }

        [Test]
        public void FindMedianOfTwoArraysTest_EmptyLists()
        {
            var arr1 = Array.Empty<int>();
            var arr2 = new int[0];

            Assert.Throws<ArgumentException>(
                () => FindMedianOfTwoArrays.MedianOfTwoArrays(arr1, arr2), "Both arrays are empty.");
        }
    }
}
