using System;

class Program
{
    enum TempUnit
    {
        Celsius = 1,
        Fahrenheit,
        Kelvin
    }

    static void Main()
    {
        Console.WriteLine("Выберите исходную единицу измерения:");
        Console.WriteLine("1 - Цельсий");
        Console.WriteLine("2 - Фаренгейт");
        Console.WriteLine("3 - Кельвин");
        Console.Write("Введите номер: ");
        int fromUnit = int.Parse(Console.ReadLine());

        Console.WriteLine("Выберите конечную единицу измерения:");
        Console.WriteLine("1 - Цельсий");
        Console.WriteLine("2 - Фаренгейт");
        Console.WriteLine("3 - Кельвин");
        Console.Write("Введите номер: ");
        int toUnit = int.Parse(Console.ReadLine());

        Console.Write("Введите температуру: ");
        double temp = double.Parse(Console.ReadLine());

        double tempInCelsius = 0;

        // Переводим в Цельсий
        if (fromUnit == (int)TempUnit.Celsius)
            tempInCelsius = temp;
        else if (fromUnit == (int)TempUnit.Fahrenheit)
            tempInCelsius = (temp - 32) * 5 / 9;
        else if (fromUnit == (int)TempUnit.Kelvin)
            tempInCelsius = temp - 273.15;

        double result = 0;

        // Переводим из Цельсия в нужную шкалу
        if (toUnit == (int)TempUnit.Celsius)
            result = tempInCelsius;
        else if (toUnit == (int)TempUnit.Fahrenheit)
            result = tempInCelsius * 9 / 5 + 32;
        else if (toUnit == (int)TempUnit.Kelvin)
            result = tempInCelsius + 273.15;

        Console.WriteLine($"Результат: {result:F2}");
    }
}