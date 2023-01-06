using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_ifelse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number: ");
            double first = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number: ");
            double second = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the operation (+, -, *, /): ");
            string op = Console.ReadLine();
            
            if(op == "+")
                Console.WriteLine(first + " + " + second + " = " + (first + second));
            else if(op == "-")
                Console.WriteLine(first + " - " + second + " = " + (first - second));
            else if(op == "*")
                Console.WriteLine(first + " * " + second + " = " + first * second);
            else if(op == "/") {
                if (second != 0)
                    Console.WriteLine(first + " / " + second + " = " + first / second);
                else
                    Console.WriteLine("Can't divide by zero");
            }
            else
                Console.WriteLine("Undefined symbol");

            Console.ReadLine();
        }
    }
}
