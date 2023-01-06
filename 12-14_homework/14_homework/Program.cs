using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_homework
{
    class Program
    {
        static void Main(string[] args)
        {
            //Методы для удаления с начала, конца и по индексу
            Console.Write("Array length: ");
            if (!uint.TryParse(Console.ReadLine(), out uint length))
            {
                Console.WriteLine("This is not an unsigned int");
                return;
            }

            int[] arr = new int[length];

            FillRandom(arr);
            PrintArray(arr);

            DeleteStart(ref arr);
            PrintArray(arr);

            DeleteEnd(ref arr);
            PrintArray(arr);

            DeleteIndex(ref arr);
            PrintArray(arr);

            Console.ReadLine();
        }

        static void FillRandom(int[] arr)
        {
            Random random = new Random();
            for (int i = 0; i < arr.Length; i++)
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

        static void DeleteStart(ref int[] arr)
        {
            Console.WriteLine("\nFirst element deleted: ");

            int[] newArr = new int[arr.Length - 1];

            for (int i = 1; i < arr.Length; i++)
            {
                newArr[i - 1] = arr[i];
            }
            arr = newArr;
        }

        static void DeleteEnd(ref int[] arr)
        {
            Console.WriteLine("\nLast element deleted: ");

            int[] newArr = new int[arr.Length - 1];

            for (int i = 0; i < arr.Length - 1; i++)
            {
                newArr[i] = arr[i];
            }
            arr = newArr;
        }

        static void DeleteIndex(ref int[] arr)
        {
            Console.WriteLine("\nEnter the index: ");
            if (!uint.TryParse(Console.ReadLine(), out uint index))
            {
                Console.WriteLine("This is not an uint");
                return;
            }

            int[] newArr = new int[arr.Length - 1];

            if (index < arr.Length - 1)
            {
                for (int i = 0; i < index; i++)
                {
                    newArr[i] = arr[i];
                }

                for (int i = (int)index + 1; i < arr.Length; i++)
                {
                    newArr[i - 1] = arr[i];
                }
                arr = newArr;
            }
            else
            {
                DeleteEnd(ref arr);
            }
        }
    }
}
