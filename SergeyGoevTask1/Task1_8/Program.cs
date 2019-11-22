using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[,,] arrayOfNumbers = new int[5, 5, 5];


            for(int i = 0; i < arrayOfNumbers.GetLength(0); i++)
            {
                Console.WriteLine();
                for(int j = 0; j < arrayOfNumbers.GetLength(1); j++)
                {
                    Console.Write("{");
                    for(int k = 0; k < arrayOfNumbers.GetLength(2); k++)
                    {
                        arrayOfNumbers[i, j, k] = rnd.Next(-100, 100);
                        Console.Write(arrayOfNumbers[i,j,k] + ",");
                    }
                    Console.Write("}");
                    Console.WriteLine();
                }
            }

            Console.WriteLine("Массив с заменой положительных чисел на 0");

            for (int i = 0; i < arrayOfNumbers.GetLength(0); i++)
            {
                Console.WriteLine();
                for (int j = 0; j < arrayOfNumbers.GetLength(1); j++)
                {
                    Console.Write("{");
                    for (int k = 0; k < arrayOfNumbers.GetLength(2); k++)
                    {
                        arrayOfNumbers[i,j,k] = arrayOfNumbers[i,j,k] > 0 ? 0 : arrayOfNumbers[i,j,k];
                        Console.Write(arrayOfNumbers[i, j, k] + ",");
                    }
                    Console.Write("}");
                }
            }



            Console.ReadKey();
        }
    }
}
