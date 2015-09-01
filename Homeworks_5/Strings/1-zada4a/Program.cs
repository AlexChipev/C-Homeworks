using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_zada4a
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string word = Console.ReadLine();
            Console.WriteLine();

            string reverse = ReverseString(word);
            Console.WriteLine("Reversed string: {0}", reverse);
            Console.WriteLine();
        }

        public static string ReverseString(string word)
        {
            StringBuilder reversed = new StringBuilder();
            for (int i = word.Length - 1; i >= 0; i--)
            {
                reversed.Append(word[i]);
            }
            return reversed.ToString();
        }
    }
}
