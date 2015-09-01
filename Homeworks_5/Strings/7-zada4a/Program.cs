using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace _7_zada4a
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader file = new StreamReader("D:\\C-Homeworks\\Homeworks_5\\Strings\\7-zada4a\\File.txt"))
            {
                string line = file.ReadLine();
                int lineNum = 1;
                using (StreamWriter even = new StreamWriter("D:\\C-Homeworks\\Homeworks_5\\Strings\\7-zada4a\\Even.txt"))
                using (StreamWriter odd = new StreamWriter("D:\\C-Homeworks\\Homeworks_5\\Strings\\7-zada4a\\Odd.txt"))
                {
                    while (line != null)
                    {
                        lineNum++;
                        line = file.ReadLine();
                        if (lineNum % 2 == 0)
                        {
                            string evenNum = line;
                            even.WriteLine(evenNum);
                        }
                        else
                        {
                            string oddNum = line;
                            odd.WriteLine(oddNum);
                        }
                    }
                }
            }
        }
    }
}




