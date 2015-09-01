using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _6_zada4a
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader text = new StreamReader("D:\\C-Homeworks\\Homeworks_5\\Strings\\6-zada4a\\Text.txt"))
            {
                using (StreamWriter text2 = new StreamWriter("D:\\C-Homeworks\\Homeworks_5\\Strings\\6-zada4a\\Text2.txt"))
                {
                    StringBuilder copy = new StringBuilder();
                    string textRead = text.ReadToEnd();
                    string[] read = textRead.Split(',', '.', '!', '?', ':', ';');

                    foreach (var item in read)
                    {
                        copy.Append(item);
                    }
                    text2.WriteLine(copy);
                }
            }
        }
    }
}