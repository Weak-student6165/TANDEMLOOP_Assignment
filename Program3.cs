using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(" Hello! Welcome to the Odd Number Series (Problem-3).");
        Console.Write("Please enter a positive integer (a): ");

        if (!int.TryParse(Console.ReadLine(), out int a) || a <= 0)
        {
            Console.WriteLine("Invalid input! Please enter a positive integer greater than 0.");
            return;
        }

        List<int> series = GenerateSeries(a);

        Console.WriteLine($"\n The series for a = {a} is:");
        Console.WriteLine(string.Join(", ", series));
        Console.WriteLine("\nThank you for using the Odd Number Series Generator");
    }

    private static List<int> GenerateSeries(int a)
    {
        int terms = (a % 2 == 0) ? a - 1 : a; 
        var result = new List<int>();

        for (int i = 0; i < terms; i++)
        {
            result.Add(2 * i + 1); 
        }

        return result;
    }
}
