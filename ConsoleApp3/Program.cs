using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите число:");
        if (int.TryParse(Console.ReadLine(), out int userInput))
        {
            if (userInput >= 5 && userInput <= 10)
            {
                Console.WriteLine("Число больше 5 и меньше 10.");
            }
            else
            {
                Console.WriteLine("Неизвестное число.");
            }
        }
        else
        {
            Console.WriteLine("Ошибка ввода числа.");
        }

        Console.ReadLine();
    }
}
