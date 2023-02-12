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

    }
}