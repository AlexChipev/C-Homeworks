using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_zada4a
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a word: ");
            string word = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Now type in a short text using the word several times");
            string text = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine(text.Replace(word, word.ToUpper()));
            Console.WriteLine();
        }
    }
}