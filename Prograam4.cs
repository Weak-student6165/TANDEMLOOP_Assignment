using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello! Welcome to Multiples Counter (Problem-4).");

        Console.WriteLine("\nPlease enter numbers separated by spaces (e.g., 1 2 8 9 12 46 76 82 15 20 30):");
        string input = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("Invalid input! Please provide at least one number.");
            return;
        }

        int[] numbers;
        try
        {
            numbers = input.Split(' ', StringSplitOptions.RemoveEmptyEntries)
                           .Select(int.Parse)
                           .ToArray();
        }
        catch
        {
            Console.WriteLine("Invalid format! Please enter only integers separated by spaces.");
            return;
        }

        Dictionary<int, int> result = CountMultiples(numbers);

        Console.WriteLine("\nMultiples count result:");
        Console.WriteLine("{" + string.Join(", ", result.Select(kv => $"{kv.Key}: {kv.Value}")) + "}");
        Console.WriteLine("\nThank you for using the Multiples Counter!");
    }

    private static Dictionary<int, int> CountMultiples(int[] numbers)
    {
        var multiples = new Dictionary<int, int>();

        for (int i = 1; i <= 9; i++)
        {
            int count = numbers.Count(n => n % i == 0);
            multiples[i] = count;
        }

        return multiples;
    }
}
