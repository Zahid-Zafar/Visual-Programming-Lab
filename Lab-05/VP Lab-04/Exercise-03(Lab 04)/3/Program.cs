using System;

namespace Ex
{
    class Program
    {
        public static void Main()
        {
            string inputString = "This is an example string with various words";
            ExtractWords(inputString);
        }

        public static void ExtractWords(string text)
        {
            string vowels = "aeiouAEIOU";
            string[] words = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            foreach (string word in words)
            {
                if (word.Length >= 4 && word.Length <= 5 && ContainsVowel(word, vowels))
                {
                    Console.WriteLine(word);
                }
            }
        }

        private static bool ContainsVowel(string word, string vowels)
        {
            foreach (char c in word)
            {
                if (vowels.Contains(c))
                {
                    return true;
                }
            }
            return false; // Return false only after checking all characters
        }
    }
}
