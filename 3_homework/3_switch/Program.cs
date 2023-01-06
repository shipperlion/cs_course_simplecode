using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_switch
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
            switch (op)
            {
                case "+":
                    Console.WriteLine(first + " + " + second + " = " + (first + second));
                    break;
                case "-":
                    Console.WriteLine(first + " - " + second + " = " + (first - second));
                    break;
                case "*":
                    Console.WriteLine(first + " * " + second + " = " + first * second);
                    break;
                case "/":
                    if(second != 0)
                        Console.WriteLine(first + " / " + second + " = " + first / second);
                    else
                        Console.WriteLine("Can't divide by zero");
                    break;
                default:
                    Console.WriteLine("Undefined symbol");
                    break;
            }
            Console.ReadLine();
        }
    }
}
