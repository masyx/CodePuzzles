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
        public void RotateArrayTest_EmptyArray()
        {
            var array = new int[0];

            var rotator = new LeetCode.RotateArray();
            var rotatedArray = rotator.RotateArrayMethod(array, 2);

            Assert.IsEmpty(rotatedArray);

        }

        [Test]
        public void RotateArrayInPlaceMethodTest_1()
        {
            var array = new int[] { 1, 2, 3, 4 };

            var rotator = new RotateArray();
            rotator.RotateArrayInPlace(array, 2);

            Assert.AreEqual(2, array[3]); // expecting to see number 2 shifted to idx 3
        }

        [Test]
        public void RotateArrayInPlaceMethodTest_EmptyArray()
        {
            var array = new int[0];

            Assert.IsEmpty(array);
            //Assert.Throws<ArgumentException>(() => new RotateArray().RotateArrayInPlace(array, 99));
        }

        [Test]
        public void RotateArrayInPlaceBestTest()
        {
            var array = new int[] { 1, 2, 3, 4 };

            var rotator = new RotateArray();
            rotator.RotateArrayInPlaceBest(array, 3);

            Assert.AreEqual(1, array[3]); // expecting to see number 2 shifted to idx 3
        }

        [Test]
        public void RotateArrayInPlaceBestTest_EmptyArray()
        {
            var array = new int[0];

            Assert.Throws<ArgumentException>(() => new RotateArray().RotateArrayInPlaceBest(array, 99));
        }
    }
}