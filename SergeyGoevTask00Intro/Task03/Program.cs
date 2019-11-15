using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите высоту стороны квадрата, число должно быть нечетным");
            int numsOfRows = Convert.ToInt32(Console.ReadLine());

            if (numsOfRows % 2 != 0 && numsOfRows % 1 == 0)
            {

                for (int i = 1; i <= numsOfRows; i++)
                {
                    for (int j = 1; j <= numsOfRows; j++)
                    {
                        if (i == numsOfRows / 2 + 1 && j == numsOfRows / 2 + 1)
                        {
                            Console.Write(" ");
                        }
                        else
                        {
                            Console.Write("*");
                        }
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Вы ввели четное число");
            }
            Console.ReadLine();
        }
    }
}
