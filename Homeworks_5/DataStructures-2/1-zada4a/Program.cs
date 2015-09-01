using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_zada4a
{
    class Program
    {
        private static string TEXT = Console.ReadLine();        
        static void Main()
        {
            SortedDictionary<String, int> wordCount = WordCounter(TEXT);
            PrintCount(wordCount);   
        }
        private static SortedDictionary<string, int> WordCounter(string text)
        {
            string[] split = text.Split(' ', '.', ',', '-', '?', '!', ';', ':');
            SortedDictionary<string, int> words = new SortedDictionary<string, int>();
            foreach (string word in split)
            {
                if (string.IsNullOrEmpty(word.Trim()))
                {
                    continue;
                }
                int count;
                if (!words.TryGetValue(word, out count))
                {
                    count = 0;
                }
                words[word] = count + 1;
            }
            return words;
        }
        private static void PrintCount(SortedDictionary<string, int> WordCounter)
        {
            Console.WriteLine();
            foreach (KeyValuePair<string, int> wordEntry
            in WordCounter)
            {
                Console.WriteLine("Word '{0}' occurances in the text: {1} time(s)",
                wordEntry.Key, wordEntry.Value);
            }
            Console.WriteLine();
        }
    }
}
