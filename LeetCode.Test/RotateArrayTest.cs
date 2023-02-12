using NUnit.Framework;

namespace LeetCode.Test
{
    [TestFixture]
    public class RotateArrayTest
    {

        [Test]
        public void RotateArrayTest_1()
        {
            var array = new int[] { 1,2,3,4 };

            var rotator = new LeetCode.RotateArray();
            var rotatedArray = rotator.RotateArrayMethod(array, 2);

            Assert.AreEqual(1, rotatedArray[2]);
            
        }

        [Test]
        public void RotateArrayTest_2()
        {
            var array = new int[] { };

            var rotator = new LeetCode.RotateArray();
            var rotatedArray = rotator.RotateArrayMethod(array, 2);

            Assert.IsEmpty(rotatedArray);

        }

    }
}