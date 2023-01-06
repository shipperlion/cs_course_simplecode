using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_homework
{
    class Program
    {
        static void Main(string[] args)
        {
            //Написать метод, изменяющий количество элементов массива
            Console.Write("Array length: ");
            if (!uint.TryParse(Console.ReadLine(), out uint length))
            {
                Console.WriteLine("This is not an unsigned int");
                return;
            }

            int[] arr = new int[length];

            FillRandom(arr);
            PrintArray(arr);
            ResizeArray(ref arr);
            PrintArray(arr);

            Console.ReadLine();
        }

        static void FillRandom(int[] arr)
        {
            Random random = new Random();
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(100);
            }
        }

        static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + "\t");
            }
        }

        static void ResizeArray(ref int[] arr)
        {
            Console.WriteLine("\nNew size: ");

            if (!uint.TryParse(Console.ReadLine(), out uint newLength))
            {
                Console.WriteLine("This is not an unsigned int");
                return;
            }

            int[] newArr = new int[newLength];

            if(newArr.Length > arr.Length)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    newArr[i] = arr[i];
                }

                Random random = new Random();
                for (int i = arr.Length; i < newArr.Length; i++)
                {
                    newArr[i] = random.Next(100);
                }
            }
            else
            {
                for (int i = 0; i < newArr.Length; i++)
                {
                    newArr[i] = arr[i];
                }
            }
            arr = newArr;
        }
    }
}
