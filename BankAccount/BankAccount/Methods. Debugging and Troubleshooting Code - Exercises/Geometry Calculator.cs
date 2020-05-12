using System;

namespace _11_geometry_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();
            double result = 0;
            if (figure == "triangle")
            {
                double side = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                result = GetTriangleArea(side, height);
                Console.WriteLine($"{result:F2}");
            }
            else if (figure == "square")
            {
                double side = double.Parse(Console.ReadLine());
                result = GetSquareArea(side);
                Console.WriteLine($"{result:F2}");
            }
            else if (figure == "rectangle")
            {
                double width = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                result = GetRectangleArea(width, height);
                Console.WriteLine($"{result:F2}");
            }
            else if (figure == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                result = GetCircleArea(radius);
                Console.WriteLine($"{result:F2}");
            }

        }

        static double GetTriangleArea(double side, double height)
        {
            double area = (side * height) / 2;
            return area;
        }
        static double GetSquareArea(double side)
        {
            double area = side * side;
            return area;
        }
        static double GetRectangleArea(double width, double height)
        {
            double area = width * height;
            return area;
        }
        static double GetCircleArea(double radius)
        {
            double area = Math.PI * radius * radius;
            return area;
        }
    }
}
