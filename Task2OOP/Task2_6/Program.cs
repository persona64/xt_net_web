using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_6
{
    class Program
    {
        static void Main(string[] args)
        {
            double inputCoordinatX;
            double inputCoordinatY;
            double inputInnerRadius;
            double inputOuterRadius;

            Console.WriteLine("Введите координату Х: ");
            while(!double.TryParse(Console.ReadLine(), out inputCoordinatX))
            {
                Console.WriteLine("Введите число с плавающей точкой!");
            }

            Console.WriteLine("Введите координату Y: ");
            while(!double.TryParse(Console.ReadLine(), out inputCoordinatY))
            {
                Console.WriteLine("Введите число с плавающей точкой!");
            }

            Console.WriteLine("Введите радиус внешнего кольца");
            while(!double.TryParse(Console.ReadLine(), out inputOuterRadius))
            {
                Console.WriteLine("Введите число с плавающей точкой!");
            }

            Console.WriteLine("Введите радиус внутреннего радиуса");
            while(!double.TryParse(Console.ReadLine(), out inputInnerRadius))
            {
                Console.WriteLine("Введите число с плавающей точкой!");
            }

            Ring ring1 = new Ring(240.0, 120.0, 24.0, 36.0);
            ring1.X = inputCoordinatX;
            ring1.Y = inputCoordinatY;
            ring1.OuterRadius = inputOuterRadius;
            ring1.InnerRadius = inputInnerRadius;
            var ringArea = (ring1 as Ring).GetRingArea();
            var ringLength = (ring1 as Ring).GetLength();

            Console.WriteLine("Координаты Х: {0} и Y: {1}", inputCoordinatX, inputCoordinatY);
            Console.WriteLine("Площадь кольца равна: " + ringArea);
            Console.WriteLine("Длина окружностей кольца равна: " + ringLength);
            Console.ReadLine();


            Console.ReadLine();
        }

        class Ring
        {
            public double X;
            public double Y;
            public double OuterRadius;
            public double InnerRadius;

            public Ring(double xCoordinat, double yCoordinat, double outerRadius, double innerRadius)
            {
                X = xCoordinat;
                Y = yCoordinat;
                OuterRadius = outerRadius;
                InnerRadius = innerRadius;
            }
            public double GetRingArea() => Math.PI * OuterRadius * OuterRadius * ((InnerRadius + 1.0) / (InnerRadius - 1.0));
            public double GetLength() => (2 * Math.PI * OuterRadius) + (2 * Math.PI * InnerRadius);
        }
    }
}
