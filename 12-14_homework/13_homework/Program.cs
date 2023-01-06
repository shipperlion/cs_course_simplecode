using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_homework
{
    class Program
    {
        static void Main(string[] args)
        {
            //Методы для добавления в начало, конец и по индексу
            Console.Write("Array length: ");
            if (!uint.TryParse(Console.ReadLine(), out uint length))
            {
                Console.WriteLine("This is not an unsigned int");
                return;
            }

            int[] arr = new int[length];

            FillRandom(arr);
            PrintArray(arr);

            AddStart(ref arr);
            PrintArray(arr);

            AddEnd(ref arr);
            PrintArray(arr);

            AddIndex(ref arr);
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

        static void AddStart(ref int[] arr)
        {
            Console.WriteLine("\nEnter element to add to the start: ");
            if (!int.TryParse(Console.ReadLine(), out int element))
            {
                Console.WriteLine("This is not an int");
                return;
            }

            int[] newArr = new int[arr.Length + 1];

            newArr[0] = element;
            for(int i = 0; i < arr.Length; i++)
            {
                newArr[i + 1] = arr[i];
            }
            arr = newArr;
        }

        static void AddEnd(ref int[] arr)
        {
            Console.WriteLine("\nEnter element to add to the end: ");
            if (!int.TryParse(Console.ReadLine(), out int element))
            {
                Console.WriteLine("This is not an int");
                return;
            }

            int[] newArr = new int[arr.Length + 1];

            newArr[newArr.Length-1] = element;
            for (int i = 0; i < arr.Length; i++)
            {
                newArr[i] = arr[i];
            }
            arr = newArr;
        }

        static void AddEnd(ref int[] arr, int element)
        {

            int[] newArr = new int[arr.Length + 1];

            newArr[newArr.Length - 1] = element;
            for (int i = 0; i < arr.Length; i++)
            {
                newArr[i] = arr[i];
            }
            arr = newArr;
        }

        static void AddIndex(ref int[] arr)
        {
            Console.WriteLine("\nEnter the index: ");
            if (!uint.TryParse(Console.ReadLine(), out uint index))
            {
                Console.WriteLine("This is not an uint");
                return;
            }

            Console.WriteLine("Enter element to add: ");
            if (!int.TryParse(Console.ReadLine(), out int element))
            {
                Console.WriteLine("This is not an int");
                return;
            }

            int[] newArr = new int[arr.Length + 1];

            if (index < newArr.Length - 1)
            {
                newArr[index] = element;
                for (int i = 0; i < index; i++)
                {
                    newArr[i] = arr[i];
                }

                for (int i = (int)index + 1; i < newArr.Length; i++)
                {
                    newArr[i] = arr[i - 1];
                }
                arr = newArr;
            }
            else
            {
                AddEnd(ref arr, element);
            }
        }
    }
}
