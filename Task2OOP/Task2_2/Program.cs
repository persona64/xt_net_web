using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите поочередно стороны треугольника: ");
            AreaTriangle area = new AreaTriangle();

            var sideA = Convert.ToInt32(Console.ReadLine());
            var sideB = Convert.ToInt32(Console.ReadLine());
            var sideC = Convert.ToInt32(Console.ReadLine());

            area.SideA = sideA;
            area.SideB = sideB;
            area.SideC = sideC;

            var areaCircle = (area as AreaTriangle).areaTriangle();
            Console.WriteLine("Периметр треугольника равен: " + areaCircle);

            Console.ReadLine();

        }

        class Triangle
        {
            public int SideA;
            public int SideB;
            public int SideC;
        }

        class AreaTriangle : Triangle
        {
            public double areaTriangle() => SideA + SideB + SideC;
        }
    }
}
