using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int n = int.Parse(Console.ReadLine());

        while (n % 3 != 0 && n % 5 != 0 && n % 6 != 0)
        {
            n++;
        }

        Console.WriteLine($"Final value of n: {n}");
    }
}