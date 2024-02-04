using System;

class Program
{
    static void Main()
    {
        double firstNumber, secondNumber;

        Console.WriteLine("Введите первое число:");
        if (!double.TryParse(Console.ReadLine(), out firstNumber))
        {
            Console.WriteLine("Ошибка ввода первого числа.");
            return;
        }

        Console.WriteLine("Введите второе число:");
        if (!double.TryParse(Console.ReadLine(), out secondNumber))
        {
            Console.WriteLine("Ошибка ввода второго числа.");
            return;
        }

        if (firstNumber == secondNumber)
        {
            Console.WriteLine("Введенные числа равны.");
        }
        else if (firstNumber > secondNumber)
        {
            Console.WriteLine("Первое число больше второго.");
        }
        else
        {
            Console.WriteLine("Первое число меньше второго.");
        }

        Console.ReadLine();
    }
}
