using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a value: ");
        int remainingValue = int.Parse(Console.ReadLine());
        Console.WriteLine();

        while (remainingValue > 0)
        {
            Console.Write("Enter subtrahend: ");
            int subtrahend = int.Parse(Console.ReadLine());
            remainingValue -= subtrahend;

            Console.WriteLine($"{remainingValue + subtrahend} - {subtrahend} = {remainingValue}");
        }
    }
}