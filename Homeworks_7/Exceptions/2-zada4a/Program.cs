using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _2_zada4a
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader txt = new StreamReader("D:\\C-Homeworks\\Homeworks_7\\Exceptions\\2-zada4a\\SentenceNotCompleted.txt"))
            {
                string line = txt.ReadLine();

                while (line != null)
                {
                    try
                    {
                        ReadLine(line);
                    }
                    catch (SentenceNotCompletedException error)
                    {
                        Console.WriteLine();
                        Console.WriteLine(error.Message);
                        Console.WriteLine();
                        break;
                    }
                    line = txt.ReadLine();
                }
            }
        }
        static void ReadLine(string line)
        {
            {
                if (line.EndsWith(".") || line.EndsWith("!") || line.EndsWith("?"))
                {
                    Console.WriteLine(line);
                }
                else
                {
                    throw new SentenceNotCompletedException("There is at least one sentence which doesnt end properly!");
                }
            }
        }
    }
}
