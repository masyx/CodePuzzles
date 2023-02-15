namespace LeetCode
{
    public class RotateArray
    {
        public int[] RotateArrayMethod(int[] array, int k)
        {
            int[] result = new int[array.Length];
            for(int i = 0; i < array.Length; i++)
            {
                result[(i + k) % array.Length] = array[i];
            }
            return result;
        }

        public void RotateArrayInPlace(int[] array, int k)
        {
            var length = array.Length;
            if (length == 0)
                //throw new ArgumentException("Array is empty.");
                return;
            k %= length;
            for(int i = 0; i < k; i++)
            {
                var previous = array[length - 1];
                for(int j = 0; j < length; j++)
                {
                    var temp = array[j];
                    array[j] = previous;
                    previous = temp;
                }
            }
        }
    }
}