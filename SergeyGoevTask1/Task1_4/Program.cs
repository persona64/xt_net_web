using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_4
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputNumber = Console.ReadLine();
            int numberOfTriangles = 0;

            if (Int32.TryParse(inputNumber, out numberOfTriangles))
            {
                for (int i = 0; i < numberOfTriangles; i++)
                {
                    for (int j = 0; j < i; j++)
                    {
                        string branch = new String('*', j);
                        Console.WriteLine(branch.PadLeft(numberOfTriangles + 3) + "*" + branch);
                    }
                }
            }
            else
            {
                Console.WriteLine("Введите число, а не строку");
            }

            Console.ReadLine();
        }
    }
}
