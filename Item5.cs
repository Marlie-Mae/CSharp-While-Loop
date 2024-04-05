using System;

class Program 
{
    static void Main(string[] args)
    {
        Console.Write("Enter i: ");
        int i = int.Parse(Console.ReadLine());
        
        if (i % 2 != 0) 
        {
            i++; 
        } 
        
        while (i <= 98) 
        {
            Console.WriteLine(i);
            i += 2;
        } 
    }
}