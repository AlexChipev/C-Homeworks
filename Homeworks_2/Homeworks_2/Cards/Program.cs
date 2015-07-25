using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cards
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a card: ");
            string cardSymbol = Console.ReadLine();

            switch (cardSymbol)
            {
                case "2":
                case "3":
                case "4":
                case "5":
                case "6":
                case "7":
                case "8":
                case "9":
                case "10":
                case "J":
                case "K":
                case "Q":
                case "A":

                    Console.WriteLine("Valid");
                    break;
                default:
                    Console.WriteLine("Unvalid");
                    break;
            }
        }
    }
}