using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] arrayOfNumbers = new int[20];

            for(int i = 0; i < arrayOfNumbers.Length; i++)
            {
                arrayOfNumbers[i] = rnd.Next(-100, 100);
                Console.WriteLine(arrayOfNumbers[i]);
            }
            Console.WriteLine();
            

            int sum = 0;
            for(int i = 0; i < arrayOfNumbers.Length; i++)
            {
                if(arrayOfNumbers[i] > 0)
                {
                    Console.WriteLine(sum = sum + arrayOfNumbers[i]);
                }
            }

            Console.ReadLine();
        }
    }
}
