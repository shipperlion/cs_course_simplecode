using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_homework
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sum of the even numbers
            Console.WriteLine("Enter the number of elements:");
            int length = int.Parse(Console.ReadLine());

            int[] arr = new int[length];

            Console.WriteLine("Enter the array:");

            for (uint i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            int sumOfEven = 0;
            for (uint i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                    sumOfEven += arr[i];
            }
            Console.Write("Sum of the even numbers: " + sumOfEven);

            Console.ReadLine();
        }
    }
}
