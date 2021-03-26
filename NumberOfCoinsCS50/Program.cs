using System;

namespace NumberOfCoinsCS50
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal dollars;
            int coins = 0;

            do
            {
                Console.Write("Change: ");
                dollars = decimal.Parse(Console.ReadLine());
            }
            while (dollars <= 0);

            int cents = (int)Math.Round(dollars * 100);

            int[] denominations = { 25, 10, 5, 1 };
            
            //int size = sizeof(denominations) / sizeof(int); c language solution

            for (int i = 0; i < denominations.Length; i++)
            {
                coins += cents / denominations[i];
                cents %= denominations[i];
            }

            Console.WriteLine($"{coins}");
        }
    }
}
