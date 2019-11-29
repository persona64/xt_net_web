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
            int radius;
            int xCoordinat;
            int yCoordinat;

            Console.WriteLine("Введите координату Х: ");
            while(!int.TryParse(Console.ReadLine(), out xCoordinat))
            {
                Console.WriteLine("Введите целое число");
            }

            Console.WriteLine("Введите координату Y: ");
            while(!int.TryParse(Console.ReadLine(), out yCoordinat))
            {
                Console.WriteLine("Введите целое число");
            }

            Console.WriteLine("Введите радиус: ");
            while(!int.TryParse(Console.ReadLine(), out radius))
            {
                Console.WriteLine("Введите целое число");
            }

            Round circle = new Round(xCoordinat, yCoordinat, radius);
            circle.Radius = radius; 
            circle.X = xCoordinat;
            circle.Y = yCoordinat;
            var area = (circle as Round).CirlceArea();
            var areaLength = (circle as Round).CircleLength();
            Console.WriteLine("Координаты Х: {0} и Y: {1}", xCoordinat, yCoordinat);
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
        
        public Round(int x, int y, int radius)
        {
            X = x;
            Y = y;
            Radius = radius;
        }
        public double CirlceArea() => Math.PI * Radius * Radius;
        public double CircleLength() => 2 * Math.PI * Radius;
    }
}
