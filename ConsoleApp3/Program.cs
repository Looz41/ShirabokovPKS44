using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Write("Введите первое число (от 0 до 10): ");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите второе число (от 0 до 10): ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            if (IsValidInput(number1) && IsValidInput(number2))
            {
                int result = number1 * number2;
                Console.WriteLine($"Результат умножения: {result}");
                break;
            }
            else
            {
                Console.WriteLine("Введенные числа недопустимы. Пожалуйста, введите числа от 0 до 10.");
            }
        }
    }

    static bool IsValidInput(int number)
    {
        return number >= 0 && number <= 10;
    }
}
