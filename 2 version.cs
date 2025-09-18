using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("�������� ��� �����:");
        Console.WriteLine("1 - ����������");
        Console.WriteLine("2 - ��������");
        Console.Write("������� ����� ���������� ����: ");
        string choice = Console.ReadLine();

        if (choice == "1")
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
        else if (choice == "2")
        {
            Console.Write("������� ����������� � ���������: ");
            string input = Console.ReadLine();

            if (double.TryParse(input, out double kelvin))
            {
                if (kelvin < 0)
                {
                    Console.WriteLine("������: ����������� � ��������� �� ����� ���� �������������.");
                }
                else
                {
                    double celsius = kelvin - 273.15;
                    Console.WriteLine($"����������� � ��������: {celsius:F2}");
                }
            }
            else
            {
                Console.WriteLine("������: ������� ������������ ��������.");
            }
        }
        else
        {
            Console.WriteLine("������������ �����. ����������, ��������� ��������� ������ � �������� 1 ��� 2.");
        }
    }
}