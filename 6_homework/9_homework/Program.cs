using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_homework
{
    class Program
    {
        static void Main(string[] args)
        {
            //Find the smallest number
            Console.WriteLine("Enter the number of elements:");
            int length = int.Parse(Console.ReadLine());

            int[] arr = new int[length];

            Console.WriteLine("Enter the array:");

            for (uint i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            int smallestNumber = int.MaxValue;

            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i] < smallestNumber)
                    smallestNumber = arr[i];
            }
            Console.Write("The smallest number: " + smallestNumber);

            Console.ReadLine();
        }
    }
}
