using System;

class Program 
{
    static void Main(string[] args)
    {
        Console.Write("Enter start: ");
        decimal start = decimal.Parse(Console.ReadLine());
        bool negativeStart = start < 0;

        while (start < 0) 
        {
            Console.Write("\nEnter a decimal number: ");
            decimal input = decimal.Parse(Console.ReadLine());
            start += input;

            Console.WriteLine($"Start current value: {start:F2}");
        }
    }
}