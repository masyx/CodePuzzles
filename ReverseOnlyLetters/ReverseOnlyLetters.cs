using System;

namespace ReverseOnlyLetters
{
    class ReverseOnlyLetters
    {
        static void Main(string[] args)
        {
            // Ab,c,de!$
            ReverseOnlyLettersMethod("Ab,c,de!$");
        }

        static void ReverseOnlyLettersMethod(string input)
        {
            Console.WriteLine($"Input string: {input}");
            char[] charArray = input.ToCharArray();

            // initialize left and right pointers
            int right = input.Length - 1;
            int left = 0;

            while(left < right)
            {
                // ignore special characters
                if (!char.IsLetter(charArray[left]))
                {
                    left++;
                }
                else if (!char.IsLetter(charArray[right]))
                {
                    right--;
                }
                // botrh charArray[left] and charArray[right] are not special
                else
                {
                    char temp = charArray[left];
                    charArray[left] = charArray[right]; // reversing the array here
                    charArray[right] = temp;
                    left++;
                    right--;
                }
            }

            var reversedString = new string(charArray);

            Console.WriteLine($"Reversed string: {reversedString}");
        }
    }
}
