using System;

//Homework lesson #8

namespace _1_lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Arithmetical mean
            double a, b;
            Console.WriteLine("Enter first number: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Arithmetical mean: (" + a + " + " + b + ") / 2 = " + ( a + b ) / 2);


            //2. Sum and product
            double c;
            Console.WriteLine("Enter first number: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter third number: ");
            c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Sum: " + a + " + " + b + " + " + c + " = " + (a + b + c));
            Console.WriteLine("Product: " + a + " * " + b + " * " + c + " = " + a * b * c);


            //3. Currency converter
            Console.WriteLine("usd: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("eur: " + a * 0.98);
            Console.WriteLine("uah: " + a * 36.9);
            Console.WriteLine("jpy: " + a * 131.2);
            Console.ReadLine();
        }
    }
}
