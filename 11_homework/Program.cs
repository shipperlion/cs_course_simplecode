using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Size of array: ");
            if (!uint.TryParse(Console.ReadLine(), out uint size))
                return;

            int[] arr = new int[size];

            Random random = new Random();
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(100);
            }

            Console.WriteLine("Array: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + "\t");
            }
            Console.WriteLine();
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(i + "\t");
            }

            Console.WriteLine("\nEnter the element of array: ");
            if (!int.TryParse(Console.ReadLine(), out int element))
                return;

            Console.Write(SearchElement(element, arr));
            Console.ReadLine();
        }

        static int SearchElement(int value, int[] arr)
        {
            
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == value)
                    return i;
            }
            return -1;
        }

    }
}
