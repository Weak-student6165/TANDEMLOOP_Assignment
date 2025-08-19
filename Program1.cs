using System;

public class Calculator
{
    public double Compute(double a, double b, string operation)
    {
        if (string.IsNullOrWhiteSpace(operation))
            throw new ArgumentException("Operation cannot be null or empty.");

        switch (operation.Trim().ToLower())
        {
            case "add":
            case "+":
                return a + b;

            case "subtract":
            case "-":
                return a - b;

            case "multiply":
            case "*":
                return a * b;

            case "divide":
            case "/":
                if (b == 0)
                    throw new DivideByZeroException("Division by zero is not allowed.");
                return a / b;

            default:
                throw new InvalidOperationException($"Unsupported operation: {operation}");
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        var calc = new Calculator();

        Console.WriteLine("Enter first number (a): ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter second number (b): ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter operation (add, subtract, multiply, divide or +, -, *, /): ");
        string operation = Console.ReadLine();

        try
        {
            double result = calc.Compute(a, b, operation);
            Console.WriteLine($"Result: {result}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}
