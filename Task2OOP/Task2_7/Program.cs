using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_7
{

    public class Shape
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Heigth { get; set; }
        public int Width { get; set; }
        public int Radius { get; set; }
        public int SideA { get; set; }
        public int SideB { get; set; }
        public int SideC { get; set; }
        public int OuterRadius { get; set; }
        public int InnerRadius { get; set; }
        public int Length { get; set; }

        public virtual void Draw()
        {
            Console.WriteLine();
        }
    }

    class Circle : Shape
    {
        public Circle(){}

        public Circle(int x, int y, int radius)
        {
            X = x;
            Y = y;
            Radius = radius;
        }

        public override void Draw()
        {
            int xCoordinat;
            int yCoordinat;
            int radius;

            Console.WriteLine("Создание круга: ");
            Console.WriteLine("Введите координату Х: ");
            while (!int.TryParse(Console.ReadLine(), out xCoordinat))
            {
                Console.WriteLine("Введите число!");
            }
            Console.WriteLine("Введите координату Y: ");
            while (!int.TryParse(Console.ReadLine(), out yCoordinat))
            {
                Console.WriteLine("Введите число");
            }
            Console.WriteLine("Введите радиус круга: ");
            while (!int.TryParse(Console.ReadLine(), out radius))
            {
                Console.WriteLine("Введите число!");
            }
            Circle circle = new Circle(xCoordinat, yCoordinat, radius);

            circle.X = xCoordinat;
            circle.Y = yCoordinat;
            circle.Radius = radius;
            var length = 2 * (Math.PI * radius);
            var area = (radius * radius) * Math.PI;
            Console.WriteLine("Координаты Х: {0} и Y: {1}", xCoordinat, yCoordinat);
            Console.WriteLine("Площадь круга равна: " + area);
            Console.WriteLine("Длина окружности равна: " + length);

            base.Draw();
        }
    }

    class Ring : Shape
    {
        public Ring(){}

        public Ring(int x, int y, int outerRadius, int innerRadius)
        {
            X = x;
            Y = y;
            OuterRadius = OuterRadius;
            InnerRadius = innerRadius;
        }

        public override void Draw()
        {
            int x;
            int y;
            int outerRadius;
            int innerRadius;

            Console.WriteLine("Создание Кольца: ");
            Console.WriteLine("Введите координату Х");
            while (!int.TryParse(Console.ReadLine(), out x))
            {
                Console.WriteLine("Введите число");
            }
            Console.WriteLine("Введите координату Y");
            while (!int.TryParse(Console.ReadLine(), out y))
            {
                Console.WriteLine("Введите число");
            }
            Console.WriteLine("Введите Внешний радиус");
            while (!int.TryParse(Console.ReadLine(), out outerRadius))
            {
                Console.WriteLine("Введите число");
            }
            Console.WriteLine("Введите внутренний радиус");
            while (!int.TryParse(Console.ReadLine(), out innerRadius))
            {
                Console.WriteLine("Введите число");
            }

            Ring ring = new Ring(x, y, outerRadius, innerRadius);
            ring.X = x;
            ring.Y = y;
            ring.OuterRadius = outerRadius;
            ring.InnerRadius = innerRadius;
            var RingArea = Math.PI * outerRadius * outerRadius * ((innerRadius + 1.0) / (innerRadius - 1.0));
            var Length = (2 * Math.PI * outerRadius) + (2 * Math.PI * innerRadius);
            Console.WriteLine("Координаты Х: {0} и Y: {1}", x, y);
            Console.WriteLine("Площадь кольца равна: " + RingArea);
            Console.WriteLine("Длина всех окружностей равна: " + Length);

            base.Draw();
        }
    }

    class Line : Shape
    {
        public Line(){}

        public Line(int x, int y, int length)
        {
            X = x;
            Y = y;
            Length = length;
        }

        public override void Draw()
        {
            int x;
            int y;
            int length;

            Console.WriteLine("Создание линии");
            Console.WriteLine("Введите координату Х");
            while (!int.TryParse(Console.ReadLine(), out x))
            {
                Console.WriteLine("Введите число");
            }
            Console.WriteLine("Введите координату Y");
            while (!int.TryParse(Console.ReadLine(), out y))
            {
                Console.WriteLine("Введите число");
            }
            Console.WriteLine("Введите длину отрезка");
            while (!int.TryParse(Console.ReadLine(), out length))
            {
                Console.WriteLine("Введите число");
            }

            Line line = new Line(x, y, length);
            line.X = x;
            line.Y = y;
            line.Length = length;
            Console.WriteLine("Координаты Х: {0} и Y: {1}", x, y);
            Console.WriteLine("Длина линии: " + length);

            base.Draw();
        }
    }

    class Triangle : Shape
    {
        public Triangle(){}

        public Triangle(int x, int y, int sideA, int sideB, int sideC, int height)
        {
            X = x;
            Y = y;
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
            Heigth = height;
        }

        public override void Draw()
        {
            int x;
            int y;
            int sideA;
            int sideB;
            int sideC;
            int height;

            Console.WriteLine("Создание треугольника");
            Console.WriteLine("Введите координату Х");
            while (!int.TryParse(Console.ReadLine(), out x))
            {
                Console.WriteLine("Введите число");
            }
            Console.WriteLine("Введите координату Y");
            while (!int.TryParse(Console.ReadLine(), out y))
            {
                Console.WriteLine("Введите число");
            }
            Console.WriteLine("Введите длину стороны А");
            while (!int.TryParse(Console.ReadLine(), out sideA))
            {
                Console.WriteLine("Введите число");
            }
            Console.WriteLine("Введите длину стороны B");
            while (!int.TryParse(Console.ReadLine(), out sideB))
            {
                Console.WriteLine("Введите число");
            }
            Console.WriteLine("Введите длину стороны C");
            while (!int.TryParse(Console.ReadLine(), out sideC))
            {
                Console.WriteLine("Введите число");
            }
            Console.WriteLine("Введите высоту треугольника");
            while(!int.TryParse(Console.ReadLine(), out height))
            {
                Console.WriteLine("Введите число!");
            }
            Triangle triangle= new Triangle(x, y, sideA, sideB, sideC, height);
            triangle.X = x;
            triangle.Y = y;
            triangle.SideA = sideA;
            triangle.SideB = sideB;
            triangle.SideC = sideC;
            triangle.Heigth = height;
            var TriangleArea = (sideB / 2) * height;
            var TriangleLength = sideA + sideB + sideC;

            Console.WriteLine("Координаты Х: {0} и Y: {1}", x, y);
            Console.WriteLine("Площадь треугольника : " + TriangleArea);
            Console.WriteLine("Длина все сторон треугольника: " + TriangleLength);

            base.Draw();
        }
    }

    class Rectangle : Shape
    {
        public Rectangle() { }
        public Rectangle(int x, int y, int sideA, int sideB)
        {
            X = x;
            Y = y;
            SideA = sideA;
            SideB = sideB;
        }
        public override void Draw()
        {
            int x;
            int y;
            int sideA;
            int sideB;

            Console.WriteLine("Создание прямоугольника");
            Console.WriteLine("Введите координату X: ");
            while(!int.TryParse(Console.ReadLine(), out x))
            {
                Console.WriteLine("Введите число!");
            }
            Console.WriteLine("Введите координату Y: ");
            while (!int.TryParse(Console.ReadLine(), out y))
            {
                Console.WriteLine("Введите число!");
            }
            Console.WriteLine("Введите сторону А: ");
            while (!int.TryParse(Console.ReadLine(), out sideA))
            {
                Console.WriteLine("Введите число!");
            }
            Console.WriteLine("Введите сторону B : ");
            while (!int.TryParse(Console.ReadLine(), out sideB))
            {
                Console.WriteLine("Введите число!");
            }

            Rectangle rectangle = new Rectangle(x, y, sideA, sideB);
            rectangle.X = x;
            rectangle.Y = y;
            rectangle.SideA = sideA;
            rectangle.SideB = sideB;
            var area = sideA * sideB;
            var length = (sideA * 2) + (SideB * 2);

            Console.WriteLine("Координаты Х: {0} и Y: {1}", x, y);
            Console.WriteLine("Площадь прямоугольника : " + area);
            Console.WriteLine("Длина сторон прямоугольника : " + length);

            base.Draw();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var shapes = new List<Shape> { new Line(), new Circle(), new Ring(), new Rectangle(), new Triangle()};
            foreach (var shape in shapes)
            {
                shape.Draw();
            }
            //int choice;

            //Console.WriteLine("Выберите фигуру из списка: 1 Круг. 2 Кольцо. 3 Линия. 4 Треугольник. 5 Прямоугольник");
            //while(!int.TryParse(Console.ReadLine(), out choice))
            //{
            //    Console.WriteLine("Введите число от 1 до 5 для выбора фигуры");
            //}

            //if(choice == 1)
            //{

            //}
            //else if(choice == 2)
            //{

            //}
            //else if(choice == 3)
            //{

            //}
            //else if(choice == 4)
            //{

            //}
            //else if(choice == 5)
            //{

            //}

        }
        //    public static void CreateRound()
        //    {
        //        int x;
        //        int y;
        //        int radius;

        //        Console.WriteLine("Введите координату Х");
        //        while (!int.TryParse(Console.ReadLine(), out x))
        //        {
        //            Console.WriteLine("Введите число");
        //        }
        //        Console.WriteLine("Введите координату Y");
        //        while (!int.TryParse(Console.ReadLine(), out y))
        //        {
        //            Console.WriteLine("Введите число");
        //        }
        //        Console.WriteLine("Введите радиус круга");
        //        while (!int.TryParse(Console.ReadLine(), out radius))
        //        {
        //            Console.WriteLine("Введите число");
        //        }

        //        Round round = new Round(x, y, radius);
        //        round.X = x;
        //        round.Y = y;
        //        round.Radius = radius;
        //        var area = (round as Round).RoundeArea();
        //        var lengthRound = (round as Round).RoundLength();

        //        Console.WriteLine("Координаты Х: {0} и Y: {1}", x, y);
        //        Console.WriteLine("Площадь круга равна: " + area);
        //        Console.WriteLine("Длина окружности равна: " + lengthRound);
        //        Console.ReadLine();
        //    }

        //    public static void CreateRing()
        //    {
        //        int x;
        //        int y;
        //        int outerRadius;
        //        int innerRadius;

        //        Console.WriteLine("Введите координату Х");
        //        while (!int.TryParse(Console.ReadLine(), out x))
        //        {
        //            Console.WriteLine("Введите число");
        //        }
        //        Console.WriteLine("Введите координату Y");
        //        while (!int.TryParse(Console.ReadLine(), out y))
        //        {
        //            Console.WriteLine("Введите число");
        //        }
        //        Console.WriteLine("Введите Внешний радиус");
        //        while (!int.TryParse(Console.ReadLine(), out outerRadius))
        //        {
        //            Console.WriteLine("Введите число");
        //        }
        //        Console.WriteLine("Введите внутренний радиус");
        //        while (!int.TryParse(Console.ReadLine(), out innerRadius))
        //        {
        //            Console.WriteLine("Введите число");
        //        }

        //        Ring ring = new Ring(x,y,outerRadius,innerRadius);
        //        ring.X = x;
        //        ring.Y = y;
        //        ring.OuterRadius = outerRadius;
        //        ring.InnerRadius = innerRadius;
        //        var area = (ring as Ring).GetRingArea();
        //        var length = (ring as Ring).GetLength();

        //        Console.WriteLine("Координаты Х: {0} и Y: {1}", x, y);
        //        Console.WriteLine("Площадь круга равна: " + area);
        //        Console.WriteLine("Длина окружности равна: " + length);
        //        Console.ReadLine();
        //    }

        //    public static void CreateLine()
        //    {
        //        int x;
        //        int y;
        //        int length;

        //        Console.WriteLine("Введите координату Х");
        //        while (!int.TryParse(Console.ReadLine(), out x))
        //        {
        //            Console.WriteLine("Введите число");
        //        }
        //        Console.WriteLine("Введите координату Y");
        //        while (!int.TryParse(Console.ReadLine(), out y))
        //        {
        //            Console.WriteLine("Введите число");
        //        }
        //        Console.WriteLine("Введите длину линии");
        //        while (!int.TryParse(Console.ReadLine(), out length))
        //        {
        //            Console.WriteLine("Введите число");
        //        }

        //        Line line = new Line(x, y, length);
        //        line.X = x;
        //        line.Y = y;
        //        line.Length = length;

        //        Console.WriteLine("Координаты Х: {0} и Y: {1}", x, y);
        //        Console.WriteLine("Длина линии равна : " + length);
        //        Console.ReadLine();
        //    }

        //    public static void CreateTriangle()
        //    {
        //        int x;
        //        int y;
        //        int sideA;
        //        int sideB;
        //        int sideC;

        //        Console.WriteLine("Введите координату Х");
        //        while (!int.TryParse(Console.ReadLine(), out x))
        //        {
        //            Console.WriteLine("Введите число");
        //        }
        //        Console.WriteLine("Введите координату Y");
        //        while (!int.TryParse(Console.ReadLine(), out y))
        //        {
        //            Console.WriteLine("Введите число");
        //        }
        //        Console.WriteLine("Введите длину стороны А");
        //        while (!int.TryParse(Console.ReadLine(), out sideA))
        //        {
        //            Console.WriteLine("Введите число");
        //        }
        //        Console.WriteLine("Введите длину стороны Б");
        //        while (!int.TryParse(Console.ReadLine(), out sideB))
        //        {
        //            Console.WriteLine("Введите число");
        //        }
        //        Console.WriteLine("Введите длину стороны C");
        //        while (!int.TryParse(Console.ReadLine(), out sideC))
        //        {
        //            Console.WriteLine("Введите число");
        //        }

        //        Triangle triangle = new Triangle(x, y, sideA, sideB, sideC);
        //        triangle.X = x;
        //        triangle.Y = y;
        //        triangle.SideA = sideA;
        //        triangle.SideB = sideB;
        //        triangle.SideC = sideC;
        //        var area = (triangle as Triangle).GetTriangleArea();
        //        var length = (triangle as Triangle).GetTriangleLength();

        //        Console.WriteLine("Координаты Х: {0} и Y: {1}", x, y);
        //        Console.WriteLine("Площадь треугольника равна: " + area);
        //        Console.WriteLine("Длина всех сторон треугольника равна: " + length);
        //        Console.ReadLine();
        //    }

        //    public static void CreateRectangle()
        //    {
        //        int x;
        //        int y;
        //        int sideA;
        //        int sideB;

        //        Console.WriteLine("Введите координату Х");
        //        while (!int.TryParse(Console.ReadLine(), out x))
        //        {
        //            Console.WriteLine("Введите число");
        //        }
        //        Console.WriteLine("Введите координату Y");
        //        while (!int.TryParse(Console.ReadLine(), out y))
        //        {
        //            Console.WriteLine("Введите число");
        //        }
        //        Console.WriteLine("Введите длину стороны А");
        //        while (!int.TryParse(Console.ReadLine(), out sideA))
        //        {
        //            Console.WriteLine("Введите число");
        //        }
        //        Console.WriteLine("Введите длину стороны Б");
        //        while (!int.TryParse(Console.ReadLine(), out sideB))
        //        {
        //            Console.WriteLine("Введите число");
        //        }

        //        Rectangle rectangle = new Rectangle(x, y, sideA, sideB);
        //        rectangle.X = x;
        //        rectangle.Y = y;
        //        rectangle.SideA = sideA;
        //        rectangle.SideB = sideB;
        //        var area = (rectangle as Rectangle).GetTriangleArea();
        //        var length = (rectangle as Rectangle).GetTriangleLength();

        //        Console.WriteLine("Координаты Х: {0} и Y: {1}", x, y);
        //        Console.WriteLine("Площадь прямоугольника равна: " + area);
        //        Console.WriteLine("Длина всех сторон прямоугольника равна: " + length);
        //        Console.ReadLine();
        //    }
        //}

        //class Round
        //{
        //    public int X;
        //    public int Y;
        //    public int Radius;

        //    public Round(int x, int y, int radius)
        //    {
        //        X = x;
        //        Y = y;
        //        Radius = radius;
        //    }
        //    public double RoundeArea() => Math.PI * Radius * Radius;
        //    public double RoundLength() => 2 * Math.PI * Radius;
        //}

        //class Ring
        //{
        //    public double X;
        //    public double Y;
        //    public double OuterRadius;
        //    public double InnerRadius;

        //    public Ring(double xCoordinat, double yCoordinat, double outerRadius, double innerRadius)
        //    {
        //        X = xCoordinat;
        //        Y = yCoordinat;
        //        OuterRadius = outerRadius;
        //        InnerRadius = innerRadius;
        //    }
        //    public double GetRingArea() => Math.PI * OuterRadius * OuterRadius * ((InnerRadius + 1.0) / (InnerRadius - 1.0));
        //    public double GetLength() => (2 * Math.PI * OuterRadius) + (2 * Math.PI * InnerRadius);
        //}

        //class Line
        //{
        //    public double X;
        //    public double Y;
        //    public double Length;

        //    public Line(double x, double y, double length)
        //    {
        //        X = x;
        //        Y = y;
        //        Length = length;
        //    }
        //}

        //class Triangle
        //{
        //    public int X;
        //    public int Y;
        //    public int SideA;
        //    public int SideB;
        //    public int SideC;

        //    public Triangle(int x, int y, int sideA, int sideB, int sideC)
        //    {
        //        X = x;
        //        Y = y;
        //        SideA = sideA;
        //        SideB = sideB;
        //        SideC = sideC;
        //    }

        //    public int GetTriangleArea() => (SideB / 2) * GetTriangleHeight();
        //    public int GetTriangleHeight() => (2 * GetTriangleArea() / SideA);
        //    public int GetTriangleLength() => SideA + SideB + SideC;
        //}

        //class Rectangle
        //{
        //    public int X;
        //    public int Y;
        //    public int SideA;
        //    public int SideB;

        //    public Rectangle(int x, int y, int sideA, int sideB)
        //    {
        //        X = x;
        //        Y = y;
        //        SideA = sideA;
        //        SideB = sideB;
        //    }

        //    public int GetTriangleArea() => SideA * SideB;
        //    public int GetTriangleLength() => (SideA * 2) + (SideB * 2);
        //}
    }
}
