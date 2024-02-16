using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите первое целое число:");
        int a = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите второе целое число:");
        int b = int.Parse(Console.ReadLine());

        int sum = AddNumbers(a, b);
        Console.WriteLine($"Сумма чисел {a} и {b} равна {sum}");
    }

    static int AddNumbers(int num1, int num2)
    {
        return num1 + num2;
    }
}