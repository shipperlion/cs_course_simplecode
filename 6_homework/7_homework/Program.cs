using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_homework
{
    class Program
    {
        static void Main(string[] args)
        {
            //Output the array from the end
            Console.WriteLine("Enter the number of elements:");
            int length = int.Parse(Console.ReadLine());

            double[] arr = new double[length];

            Console.WriteLine("Enter the array:");

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = double.Parse(Console.ReadLine());
            }

            Console.Write("Array backwards: ");

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                Console.Write(arr[i] + " ");
            }

            Console.ReadLine();
        }
    }
}
