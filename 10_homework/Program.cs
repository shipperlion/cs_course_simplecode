using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Length of the line: ");

            if (!uint.TryParse(Console.ReadLine(), out uint length))
            {
                Console.WriteLine("That is not an unsigned integer");
                return;
            }

            Console.WriteLine("Symbol: ");

            if (!char.TryParse(Console.ReadLine(), out char symbol))
            {
                Console.WriteLine("That is not one character");
                return;
            }

            Console.WriteLine("Result line: ");
            PrintLine(length, symbol);

            Console.ReadLine();
        }

        static void PrintLine(uint length, char symbol)
        {
            for(int i = 0; i<length;i++)
                Console.Write(symbol);
        }
    }
}
