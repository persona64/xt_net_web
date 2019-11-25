using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите высоту треугольника");
            var inputNumber = Console.ReadLine();
            int sideTriangle = 0;

            if (Int32.TryParse(inputNumber, out sideTriangle))
            {
                for (int i = 0; i < sideTriangle; i++)
                {
                    for (int j = 0; j <= sideTriangle - i; j++)
                    {
                        Console.Write(" ");
                    }
                    for (int j = 0; j <= i * 2; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Вам нужно ввести число, но не строку");
            }
            Console.ReadLine();
        }
    }
}
