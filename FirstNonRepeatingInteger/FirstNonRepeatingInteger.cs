namespace FirstNonRepeatingInteger
{
    internal class FirstNonRepeatingInteger
    {
        static void Main(string[] args)
        {
            var list = new List<int> { 1, 2, 3, 1, 2, 3, 4 };
            Console.WriteLine(FirstNonRepeatingIntegerMethod(list));
        }

        private static int FirstNonRepeatingIntegerMethod(List<int> list)
        {
            var counts = new Dictionary<int, int>();
            foreach (var item in list)
            {
                if (counts.TryGetValue(item, out var value))
                {
                    counts[item] += 1;
                }
                else
                {
                    counts[item] = 1;
                }
            }

            foreach (var item in counts)
            {
                if (item.Value == 1)
                    return item.Key;
            }

            return -1;
        }
    }
}