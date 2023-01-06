using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_homework
{
    class Program
    {
        static void Main(string[] args)
        {
            //Сумму элементов массива рекурсивно

            Console.Write("Enter the size of array: ");

            int size = int.Parse(Console.ReadLine());

            int[] arr = new int[size];

            FillArray(arr);
            PrintArray(arr);
            Console.WriteLine("\nSum of array " + ArraySum(arr));

            Console.ReadLine();
        }

        static void FillArray(int[] arr)
        {
            Random random = new Random();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(50);
            }
        }

        static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + "\t");
            }
        }

        //static int ArraySum(int[] arr)
        //{
        //    if (arr.Length == 1)
        //        return arr[0];
        //    else if (arr.Length == 0)
        //        return 0;
        //    else
        //    {
        //        int[] newArr = new int[arr.Length - 1];
        //        for (int i = 0; i < newArr.Length; i++)
        //        {
        //            newArr[i] = arr[i + 1];
        //        }
        //        return arr[0] + ArraySum(newArr);
        //    }
        //}

        static int ArraySum(int[] arr, int i = 0)
        {
            if (i < arr.Length)
            {
                return arr[i] + ArraySum(arr, i + 1);
            }
            else
                return 0;
        }
    }
}
