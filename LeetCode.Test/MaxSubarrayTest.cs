using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Test
{
    [TestFixture]
    internal class MaxSubarrayTest
    {
        [Test]
        public void MaxSubarrayTest_1()
        {
            var lst = new List<int> { -10, 10, 7, -5, 15, -20 };
            Assert.AreEqual(27, MaxSubarray.MaxSubarrayValue_BruteForce(lst));
        }

        [Test]
        public void MasSubarrayTest_OneValue()
        {
            var lst = new List<int> { -10 };
            Assert.AreEqual(-10, MaxSubarray.MaxSubarrayValue_BruteForce(lst));
        }

        [Test]
        public void MasSubarrayTest_EmptyList()
        {
            var lst = new List<int>();
            Assert.Throws<ArgumentException>(() => MaxSubarray.MaxSubarrayValue_BruteForce(lst));
        }


        // Kadane's Algorithm tests
        [Test]
        public void MaxSubArrayKadanesAlgTest_1()
        {
            var lst = new List<int> { -10, 10, 7, -5, 15, -20 };
            Assert.AreEqual(27, MaxSubarray.MaxSubArrayKadanesAlg(lst));
        }

        [Test]
        public void MaxSubArrayKadanesAlgTest_OneValue()
        {
            var lst = new List<int> { -10 };
            Assert.AreEqual(-10, MaxSubarray.MaxSubarrayValue_BruteForce(lst));
        }

        [Test]
        public void MaxSubArrayKadanesAlgTest_EmptyList()
        {
            var lst = new List<int>();
            Assert.Throws<ArgumentException>(() => MaxSubarray.MaxSubarrayValue_BruteForce(lst));
        }
    }
}
