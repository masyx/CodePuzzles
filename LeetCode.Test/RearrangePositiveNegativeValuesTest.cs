using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace LeetCode.Test
{
    [TestFixture]
    internal class RearrangePositiveNegativeValuesTest
    {
        [Test]
        public void RearrangeTest()
        {
            var ints = new List<int> { 2, 6, 3, -1, -8, 5, -9};

            RearrangePositiveNegativeValues.Rearrange(ints);

            Assert.AreEqual(-9, ints[2]);
            Assert.AreEqual(2, ints[3]);
        }
    }
}
