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
        Console.WriteLine("�������� �������� ������� ���������:");
        Console.WriteLine("1 - �������");
        Console.WriteLine("2 - ���������");
        Console.WriteLine("3 - �������");
        Console.Write("������� �����: ");
        int fromUnit = int.Parse(Console.ReadLine());

        Console.WriteLine("�������� �������� ������� ���������:");
        Console.WriteLine("1 - �������");
        Console.WriteLine("2 - ���������");
        Console.WriteLine("3 - �������");
        Console.Write("������� �����: ");
        int toUnit = int.Parse(Console.ReadLine());

        Console.Write("������� �����������: ");
        double temp = double.Parse(Console.ReadLine());

        double tempInCelsius = 0;

        // ��������� � �������
        if (fromUnit == (int)TempUnit.Celsius)
            tempInCelsius = temp;
        else if (fromUnit == (int)TempUnit.Fahrenheit)
            tempInCelsius = (temp - 32) * 5 / 9;
        else if (fromUnit == (int)TempUnit.Kelvin)
            tempInCelsius = temp - 273.15;

        double result = 0;

        // ��������� �� ������� � ������ �����
        if (toUnit == (int)TempUnit.Celsius)
            result = tempInCelsius;
        else if (toUnit == (int)TempUnit.Fahrenheit)
            result = tempInCelsius * 9 / 5 + 32;
        else if (toUnit == (int)TempUnit.Kelvin)
            result = tempInCelsius + 273.15;

        Console.WriteLine($"���������: {result:F2}");
    }
}