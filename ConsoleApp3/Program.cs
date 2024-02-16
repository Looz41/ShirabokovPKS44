using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите радиус окружности:");
        double radius = double.Parse(Console.ReadLine());

        double area = CalculateCircleArea(radius);
        Console.WriteLine($"Площадь окружности с радиусом {radius} равна {area}");
    }

    static double CalculateCircleArea(double radius)
    {
        return Math.PI * radius * radius;
    }
}
