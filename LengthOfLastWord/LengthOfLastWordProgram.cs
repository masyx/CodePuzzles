using System;

namespace LengthOfLastWord
{
    class LengthOfLastWordProgram
    {
        static void Main(string[] args)
        {
            //
            //"   fly me   to   the moon "
            var i = LengthOfLastWordCPP("   fly me   to   the moon ");
            Console.WriteLine($"Length of last word is {i}");
        }

        public static int LengthOfLastWord(string input)
        {
            int lastWordLength = 0;
            int currentWordLength = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i].Equals(' '))
                {
                    currentWordLength = 0;
                } 
                else
                {
                    currentWordLength++;
                    lastWordLength = currentWordLength;
                }
            }

            return lastWordLength;      
        }

        public static int LengthOfLastWordCPP(string s)
        {
            int lengh = 0, tail = s.Length - 1;

            while (s[tail] >= 0 && s[tail] == ' ')
                tail--;
            while (s[tail] >= 0 && s[tail] != ' ')
            {
                lengh++;
                if (tail == 0)
                    break;
                    
                tail--;
            }
            return lengh;
        }
    }
}
