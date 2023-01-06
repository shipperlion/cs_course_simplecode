using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_homework
{
    class Program
    {
        static void Main(string[] args)
        {
            double start, end;
            Console.WriteLine("Enter the start of the interval: ");
            if (!double.TryParse(Console.ReadLine(), out start))
            {
                Console.WriteLine("You can enter only double or integer numbers");
                return;
            }

            Console.WriteLine("Enter the end of the interval: ");
            if (!double.TryParse(Console.ReadLine(), out end))
            {
                Console.WriteLine("You can enter only double or integer numbers");
                return;
            }

            uint even = 0, odd = 0;
            double i = Math.Ceiling(start);
            while(i<= Math.Floor(end))
            {
                if (i % 2 == 0)
                    even++;
                else
                    odd++;
                i++;
            }
            Console.WriteLine("There are " + even + " even numbers and " + odd + " odd numbers in the interval");
            Console.ReadLine();
        }
    }
}
