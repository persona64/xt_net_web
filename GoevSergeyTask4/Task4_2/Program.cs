using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] mas = new string[] { "jhadwkuqwd", "oihev", "ifofljnef", "pwofhwufhwifm", "sdf" };
            CustomBubbleSort.CustomSort(mas, Comparing.Compare);
            WriteArray.WriteArr(mas);
            Console.WriteLine();

            string[] mas1 = new string[] { "iugqgwfbh", "po9hqefoih", "ioqhefoh", "piqefoihqw", "pihf8ghw3w" };
            AnotherThread.OtherThread(mas1, Comparing.Compare);
            Console.WriteLine();

            int[] mas2 = new int[] { 5, 6, -1, 7, 5 };
            Console.WriteLine("Сумма = {0}", SumOfArray.ArraySum(mas2));
            Console.WriteLine();

            string str3 = "68484651";
            if (IsPositive.Positive(str3))
            {
                Console.WriteLine("Является положительным числом {0}", str3);
            }
            else
            {
                Console.WriteLine("Не является положительным числом {0} ", str3);
            }

            Console.ReadKey();
        }
    } 
}
