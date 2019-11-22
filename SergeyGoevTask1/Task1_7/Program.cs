using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOfNumbers = new int[25];
            Console.WriteLine("Созданный массив: ");
            for (int i = 0; i < arrayOfNumbers.Length; i++)
            {
                arrayOfNumbers[i]= rnd.Next(1000);
                Console.WriteLine(arrayOfNumbers[i]);
            }
            
            Console.WriteLine("Отсортированный массив: ");

            SortArray(arrayOfNumbers);

            for(int i = 0; i < arrayOfNumbers.Length; i++)
            {
                Console.WriteLine(arrayOfNumbers[i]);
            }
            

            int max = 0;
            int min = 0;

            for(int i = 0; i < arrayOfNumbers.Length; i++)
            {
                if(max < arrayOfNumbers[i])
                {
                    max = arrayOfNumbers[i];
                }
                for(int j = 0; j < arrayOfNumbers.Length; j++)
                {
                    if(arrayOfNumbers[j] < arrayOfNumbers[1])
                    {
                        min = arrayOfNumbers[j];
                    }
                }
            }
            Console.WriteLine("Максимальный элемент массива: " + max);
            Console.WriteLine("Минимальный элемент массива: " + min);
            Console.ReadLine();
        }

        static Random rnd = new Random();

        static void SortArray(int[] nums)
        {
            var temp = 0;

            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] > nums[j])
                    {
                        temp = nums[i];
                        nums[i] = nums[j];
                        nums[j] = temp;
                    }
                }
            }
        }
    }
}
