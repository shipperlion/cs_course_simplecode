using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number: ");
            int number;
            if (int.TryParse(Console.ReadLine(), out number)){
                if(number % 2 == 0)
                    Console.WriteLine("The number is even");
                else
                    Console.WriteLine("The number is odd");
            }
            else
                Console.WriteLine("You have entered not the integer");
            Console.ReadLine();
        }
    }
}
