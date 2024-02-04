using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите сумму вклада: ");
        double суммаВклада = Convert.ToDouble(Console.ReadLine());

        double процентнаяСтавка = (суммаВклада < 100) ? 0.05 : (суммаВклада <= 200) ? 0.07 : 0.1;

        double суммаСПроцентами = суммаВклада * (1 + процентнаяСтавка);

        Console.WriteLine($"Сумма вклада с процентами: {суммаСПроцентами}");
    }
}
