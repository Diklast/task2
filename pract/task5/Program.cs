using System;

namespace LongestWordFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение:");
            string sentence = Console.ReadLine();

            string longestWord = FindLongestWord(sentence);

            Console.WriteLine($"Самое длинное слово: {longestWord}");
        }

        static string FindLongestWord(string sentence)
        {
            string[] words = sentence.Split(new char[] { ' ', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
            string longestWord = "";

            foreach (string word in words)
            {
                if (word.Length > longestWord.Length)
                {
                    longestWord = word;
                }
            }

            return longestWord;
        }
    }
}
