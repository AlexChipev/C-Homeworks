using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _1_zada4a
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string text = "D:\\C-Homeworks\\Homeworks_7\\Exceptions\\1-zada4a\\FileTextExeption.txt";
                TextReader reader = new StreamReader(text);
                string read = reader.ReadLine();
                ReadText(text);
                CopyText(text, read);
            }
            catch (PathTooLongException file)
            {
                Console.WriteLine(file.Message);
                Console.WriteLine();
            }
            catch (Exception empty)
            {
                Console.WriteLine(empty.Message);
                Console.WriteLine();
            }
        } 
        static void ReadText(string text)
        {
            if (new FileInfo(text).Length > 10)
            {
                throw new PathTooLongException("This text consists more than 10 words!");
            }
            else
            {
                TextReader txt = new StreamReader(text);
                string read = txt.ReadLine();
                Console.WriteLine(read);
                Console.WriteLine();
                txt.Close();
            }
        }
        static void CopyText(string text, string read)
        {
            if (new FileInfo(text).Length == 0)
            {
                throw new Exception("Cannot copy empty string");
            }
            else
            {
                TextWriter write = new StreamWriter("D:\\C-Homeworks\\Homeworks_7\\Exceptions\\1-zada4a\\CopiedFileText.txt");
                write.WriteLine(read);
                write.Close();
            }
        }
    }
}

