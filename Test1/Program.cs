using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите значение x: ");
        int x = Convert.ToInt32(Console.ReadLine());

        int y = 5 * x + 20;
     
        Console.WriteLine($"Значение выражения y = 5 * x + 20 равно: {y}");
    }
}