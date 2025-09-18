using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Выберите тип ввода:");
        Console.WriteLine("1 - Фаренгейты");
        Console.WriteLine("2 - Кельвины");
        Console.Write("Введите номер выбранного типа: ");
        string choice = Console.ReadLine();

        if (choice == "1")
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
        else if (choice == "2")
        {
            Console.Write("Введите температуру в Кельвинах: ");
            string input = Console.ReadLine();

            if (double.TryParse(input, out double kelvin))
            {
                if (kelvin < 0)
                {
                    Console.WriteLine("Ошибка: температура в Кельвинах не может быть отрицательной.");
                }
                else
                {
                    double celsius = kelvin - 273.15;
                    Console.WriteLine($"Температура в Цельсиях: {celsius:F2}");
                }
            }
            else
            {
                Console.WriteLine("Ошибка: введено некорректное значение.");
            }
        }
        else
        {
            Console.WriteLine("Некорректный выбор. Пожалуйста, запустите программу заново и выберите 1 или 2.");
        }
    }
}