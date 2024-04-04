using System;

class Program
{
	static void Main(string[] args)
	{
		int total = 0;
                Console.Write("Enter x: ");
        int x = int.Parse(Console.ReadLine());

        Console.Write("Enter y: ");
        int y = int.Parse(Console.ReadLine());

        processTotals(x, y);
    }

    static void processTotals(int x, int y)
    {
        int total = 0;
        while (total < x)
        {
            total += y;
            Console.WriteLine($"Total: {total}");
        }

	}
}