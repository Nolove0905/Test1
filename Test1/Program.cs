using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите значение x: ");
        int x = Convert.ToInt32(Console.ReadLine());

        int y = 5 * x + 20;
        y *= 2; // Увеличиваем значение y в два раза

        Console.WriteLine($"Значение выражения y = 5 * x + 20 увеличенное в два раза равно: {y}");
    }
}