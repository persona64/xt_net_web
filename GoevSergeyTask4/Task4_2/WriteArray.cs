using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class WriteArray
    {
        public static void WriteArr<T>(T[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                Console.WriteLine(arr[i] + " ");
            }

            for (int i = arr.Length - 1; i < arr.Length; i++)
            {
                Console.Write(arr[i] + ".");
            }

            Console.WriteLine();
        }
    }
}
