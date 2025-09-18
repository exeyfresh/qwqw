using System;

class Program
{
    static void Main()
    {
        Console.Write("������� ����������� � �����������: ");
        string input = Console.ReadLine();

        if (double.TryParse(input, out double fahrenheit))
        {
            double celsius = (fahrenheit - 32) * 5 / 9;
            Console.WriteLine($"����������� � ��������: {celsius:F2}");
        }
        else
        {
            Console.WriteLine("������: ������� ������������ ��������.");
        }
    }
}