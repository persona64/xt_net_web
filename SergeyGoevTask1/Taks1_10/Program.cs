using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taks1_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[,] arrayOfNumbers = new int[4, 4];
            int sum = 0;

            for(int i = 0; i < arrayOfNumbers.GetLength(0); i++)
            {
                Console.WriteLine();
                for (int j = 0; j < arrayOfNumbers.GetLength(1); j++)
                {
                    arrayOfNumbers[i, j] = rnd.Next(10);
                    Console.Write("{0,3}", arrayOfNumbers[i, j]);
                }
            }
            Console.WriteLine();

            for(int i = 0; i < arrayOfNumbers.GetLength(0); i++)
            {
                Console.WriteLine();
                for(int j = 0; j < arrayOfNumbers.GetLength(1); j++)
                {
                    if ((i + j) % 2 != 0) 
                    {
                        sum += arrayOfNumbers[i, j];
                        Console.Write("{0,3}", arrayOfNumbers[i,j]);
                    }
                }
            }

            Console.ReadLine();
        }
    }
}
