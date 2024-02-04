using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите сумму вклада: ");
        decimal initialAmount = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Введите количество месяцев: ");
        int months = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < months; i++)
        {
            initialAmount += initialAmount * 0.07m;
        }

        Console.WriteLine($"Конечная сумма вклада через {months} месяцев: {initialAmount:C}");
    }
}
