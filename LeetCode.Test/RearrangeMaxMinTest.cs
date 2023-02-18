using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace LeetCode.Test
{
    [TestFixture]
    internal class RearrangeMaxMinTest
    {
        [Test]
        public void RearrangeToMaxMinTest_1()
        {
            var lst = new List<int> { 1, 2, 3, 4, 5 };
            var resultLst = RearrangeMaxMin.RearrangeToMaxMin(lst);

            Assert.AreEqual(2, resultLst[3]);
        }

        [Test]
        public void RearrangeToMaxMinTest_2()
        {
            var lst = new List<int> { 1, 2, 3, 4, 5, 6 };
            var resultLst = RearrangeMaxMin.RearrangeToMaxMin(lst);

            Assert.AreEqual(3, resultLst[5]);
        }

        [Test]
        public void RearrangeToMaxMinTestEmptyList()
        {
            var lst = new List<int>();
            var resultLst = RearrangeMaxMin.RearrangeToMaxMin(lst);

            Assert.IsEmpty(resultLst);
        }
    }
}
