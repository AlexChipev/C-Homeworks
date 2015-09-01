using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_zada4a
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a short text:");
            string text = Console.ReadLine();

            Console.WriteLine();
            Console.Write("Choose a word from the text above: ");
            string word = Console.ReadLine();

            int index = text.IndexOf(word);
            int counter = 0;

            while (index != -1)
            {
                if (text.Contains(word))
                {
                    counter++;
                }
                index = text.IndexOf(word, index + 1);
            }
            Console.WriteLine();
            Console.WriteLine("The word was used {0} time(s)", counter);
            Console.WriteLine();
        }
    }
}