using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите радиус круга");
            Circle circle = new Circle();
            int radius = Convert.ToInt32(Console.ReadLine());
            circle.Radius = radius;

            var area = (circle as Circle).CirlceArea();
            var areaLength = (circle as Circle).CircleLength();
            Console.WriteLine("Площадь круга равна: " + area);
            Console.WriteLine("Длина окружности равна: " + areaLength);
            Console.ReadLine();
        }

    }

    public class Round
    {
        public int X;
        public int Y;
        public int Radius;
    }

    class Circle : Round
    {
        public double CirlceArea() => Math.PI * Radius * Radius;
        public double CircleLength() => 2 * Math.PI * Radius;
    }

}
