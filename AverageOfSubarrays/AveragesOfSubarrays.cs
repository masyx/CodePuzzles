namespace AverageOfSubarrays
{
    internal class AveragesOfSubarrays
    {
        static void Main(string[] args)
        {
            var arr = new List<float>(){ 1, 3, 2, 6, -1, 4, 1, 8, 2 };
            var result = AveragesOfSubarraysMethod(5, arr);
            Console.WriteLine(result);
        }

        public static List<float> AveragesOfSubarraysMethod(int K, List<float> array)
        {
            var result = new List<float>();
            for(int i = 0; i <= array.Count - K; i++)
            {
                float sum = 0;
                for(int j = i; j < i + K; j++)
                {
                    sum += array[j];
                }
                result.Add(sum/K);
            }
            return result;
        }
    }
}