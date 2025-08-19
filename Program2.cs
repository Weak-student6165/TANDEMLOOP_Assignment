using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(" Hello! Welcome to the Odd Number Series Generator.");
        Console.Write("Please enter a positive integer (a): ");

        if (!int.TryParse(Console.ReadLine(), out int a) || a <= 0)
        {
            Console.WriteLine("Invalid input! Please enter a positive integer greater than 0.");
            return;
        }

        List<int> series = GenerateOddSeries(a);

        Console.WriteLine($"\n The odd number series for a = {a} is:");
        Console.WriteLine(string.Join(", ", series));
        Console.WriteLine("\n Thank you for using the Odd Number Series Generator");
    }

    private static List<int> GenerateOddSeries(int count)
    {
        var result = new List<int>();
        for (int i = 0; i < count; i++)
        {
            result.Add(2 * i + 1); 
        }
        return result;
    }
}
