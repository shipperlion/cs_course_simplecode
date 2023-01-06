using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_homework
{
    class Program
    {
        static void Main(string[] args)
        {
            //Вывод массива с помощью рекурсии

            Console.Write("Enter the size of array: ");

            int size = int.Parse(Console.ReadLine());

            int[] arr = new int[size];

            FillArray(arr);
            PrintArray(arr);

            Console.WriteLine();

            PrintArrayRec(arr);

            Console.ReadLine();
        }

        static void FillArray(int[] arr)
        {
            Random random = new Random();

            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(100);
            }
        }

        //static void PrintArrayRec(int[] arr)
        //{
        //    if (arr.Length == 1)
        //        Console.Write(arr[0] + "\t");
        //    else
        //    {
        //        Console.Write(arr[0] + "\t");
        //        int[] newArr = new int[arr.Length - 1];
        //        for(int i = 0; i < newArr.Length; i++)
        //        {
        //            newArr[i] = arr[i + 1];
        //        }
        //        PrintArrayRec(newArr);
        //    }
        //}

        static void PrintArrayRec(int[] arr, int i = 0)
        {
            if(i < arr.Length)
            {
                Console.Write(arr[i] + "\t");
                PrintArrayRec(arr, i + 1);
            }
        }

        static void PrintArray(int[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + "\t");
            }
        }
    }
}
