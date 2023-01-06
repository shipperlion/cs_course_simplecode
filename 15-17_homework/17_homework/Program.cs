using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_homework
{
    class Program
    {
        static void Main(string[] args)
        {
            //Сумму цифр числа рекурсивно
            Console.WriteLine("Enter the number: ");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("Sum of digits " + DigitSum(number));

            Console.ReadLine();
        }

        //static int DigitSum(int number)
        //{
        //    string strNumber = number.ToString();
        //    if (strNumber.Length == 1)
        //        return number;
        //    else if (strNumber.Length == 0)
        //        return 0;
        //    else
        //    {
        //        int newNumber = Convert.ToInt32(strNumber.Substring(1));
        //        return Convert.ToInt32(strNumber.Substring(0, 1)) + DigitSum(newNumber);
        //    }

        //}

        static int DigitSum(int number)
        {
            if (number < 10)
                return number;
            else
            {
                int digit = number % 10;

                int nextNumber = number / 10;

                return digit + DigitSum(nextNumber);
            }

        }
    }
}
