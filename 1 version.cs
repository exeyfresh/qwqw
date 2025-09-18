using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите температуру в Фаренгейтах: ");
        string input = Console.ReadLine();

        if (double.TryParse(input, out double fahrenheit))
        {
            double celsius = (fahrenheit - 32) * 5 / 9;
            Console.WriteLine($"Температура в Цельсиях: {celsius:F2}");
        }
        else
        {
            Console.WriteLine("Ошибка: введено некорректное значение.");
        }
    }
}