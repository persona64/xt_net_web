using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task04_05
{
    class Program
    {
       
        public static void editArray(int[][] array)
        {
            Console.Write("{");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{");
                for (int j = 0; j < array[i].Length; j++)
                {
                    Console.Write(array[i][j] + ",");
                }
                Console.Write("},");
            }
            Console.Write("}");
        }

        public static int[] randomFillArray(int[] array)
        {
            Random random = new Random();
            for (int i =0; i< array.Length; i++)
            {
                array[i] = random.Next(100);
            }
            return array;
        }

        public static int[] sortArray(int[] array)
        {
            Boolean IsSorted = false;
            while (!IsSorted)
            {
                IsSorted = true;
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i + 1] < array[i])
                    {
                        int tmp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = tmp;
                        IsSorted = false;
                    }
                }
            }
            return array;
        }

        public static int[][] sortAllArray(int[][] array)
        {
            int fullLength = 0;
            for (int i = 0; i < array.Length; i++)
            {
                fullLength = fullLength + array[i].Length;
            }
            int[] simpleArray = new int[fullLength];
            int temp = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    simpleArray[temp] = array[i][j];
                    temp++;
                }

            }
            simpleArray = sortArray(simpleArray);
            temp = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    array[i][j] = simpleArray[temp];
                    temp++;
                }

            }

            return array;
        }

        static void Main(string[] args)
        {
            Console.Write("Введите размерность массива");

            int n = Convert.ToInt32(Console.ReadLine());
            int[] length = new int[n];
            int[][] array = new int[n][];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Введите количество элементов по размеру" + (i + 1).ToString() + ": ");
                length[i] = int.Parse(Console.ReadLine());
                array[i] = new int[length[i]];
                array[i] = randomFillArray(array[i]);
            }
            Console.WriteLine("Сгенерированный массив: ");
            editArray(array);
            array = sortAllArray(array);
            Console.WriteLine();
            Console.WriteLine("Отсортированный массив: ");
            editArray(array);
            Console.ReadKey();
        }
    }
}
