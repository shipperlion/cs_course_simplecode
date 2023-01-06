using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_9_homework
{
    class Program
    {
        static void Main(string[] args)
        {
            //Enter array from the keybord
            Console.WriteLine("Enter the number of elements:");
            int length = int.Parse(Console.ReadLine());

            int[] arr = new int[length];

            Console.WriteLine("Enter the array:");

            for (uint i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.ReadLine();
        }
    }
}
