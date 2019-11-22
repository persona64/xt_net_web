using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SergeyGoevTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите поочередно строны прямоугольника");
            int sideA = 0;
            int sideB = 0;
            
            var inputSideA = Console.ReadLine();
            var inputSideB = Console.ReadLine();

            if (Int32.TryParse(inputSideA, out sideA))
            {
                sideA = Convert.ToInt32(inputSideA);
            }
            if (Int32.TryParse(inputSideB, out sideB))
            {
                sideB = Convert.ToInt32(inputSideB);
            }
            else
            {
                Console.WriteLine("Вы ввели строку");
            }
            
            int result = sideA * sideB;
            Console.WriteLine("Площадь прямоугольника: " + result);
            Console.ReadLine();
        }

    }
}
