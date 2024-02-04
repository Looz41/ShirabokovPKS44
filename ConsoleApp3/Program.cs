using System;

class Program
{
    static void Main()
    {
        // Ввод массива чисел от пользователя
        Console.Write("Введите элементы массива через пробел: ");
        string input = Console.ReadLine();
        string[] inputArray = input.Split(' ');

        // Обработка ввода и заполнение массива
        int[] numbers = new int[inputArray.Length];
        for (int i = 0; i < inputArray.Length; i++)
        {
            if (int.TryParse(inputArray[i], out numbers[i]))
            {
                // Введенные данные успешно преобразованы в целое число
            }
            else
            {
                Console.WriteLine($"Ошибка ввода! Невозможно преобразовать '{inputArray[i]}' в целое число.");
                return;
            }
        }

        Console.WriteLine("Нечетные числа из массива:");

        // Вывод нечетных чисел
        foreach (int number in numbers)
        {
            if (IsOdd(number))
            {
                Console.Write(number + " ");
            }
        }

        Console.WriteLine();
    }

    static bool IsOdd(int number)
    {
        return number % 2 != 0;
    }
}
