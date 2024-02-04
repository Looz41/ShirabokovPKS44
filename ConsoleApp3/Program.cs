using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите число: ");
        if (int.TryParse(Console.ReadLine(), out int number))
        {
            string message = (number == 5 || number == 10) ? "Число либо равно 5, либо равно 10" : "Неизвестное число";
            Console.WriteLine(message);
        }
        else
        {
            Console.WriteLine("Ошибка ввода. Введите целое число.");
        }
    }
}
