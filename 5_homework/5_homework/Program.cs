using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_homework
{
    class Program
    {
        static void Main(string[] args)
        {
            int height;
            Console.WriteLine("Enter the height of triangle: ");
            height = int.Parse(Console.ReadLine());

            char symbol;
            Console.WriteLine("Enter the symbol: ");
            symbol = char.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();
            for (int i = 0; i < height; i++)
            {
                for (int j = height; j > i; j--)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();

            for (int i = 0; i < height; i++)
            {
                for(int j = height - 1; j > i; j--)
                {
                    Console.Write(" ");
                }

                for (int j = 0; j < i + 1; j++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j <= i - 1; j++)
                {
                    Console.Write(" ");
                }

                for (int j = height; j > i; j--)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
