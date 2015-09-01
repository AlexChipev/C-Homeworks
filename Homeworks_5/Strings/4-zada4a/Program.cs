using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_zada4a
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a text:");
            string text = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine(KeyWord(text));
            Console.WriteLine();
        }
        public static string KeyWord(string text)
        {
            Console.Write("Choose a key word: ");
            string key = Console.ReadLine();

            StringBuilder keyUse = new StringBuilder();

            string[] text2 = text.Split('.');
            foreach (var item in text2)
            {
                if (item.Contains(key))
                {
                    keyUse.Append(item + '.');
                }
            }
            Console.WriteLine();
            return keyUse.ToString();
        }
    }
}
