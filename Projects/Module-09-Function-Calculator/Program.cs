
using System;

class Program
{
    // Function to add two numbers
    static int Add(int a, int b)
    {
        return a + b;
    }

    // Function to subtract two numbers
    static int Subtract(int a, int b)
    {
        return a - b;
    }

    // Function to multiply two numbers
    static int Multiply(int a, int b)
    {
        return a * b;
    }

    // Function to divide two numbers
    static double Divide(int a, int b)
    {
        return (double)a / b;
    }

    static void Main()
    {
        Console.WriteLine("===== Function Calculator =====");

        Console.Write("Enter first number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\nChoose an operation:");
        Console.WriteLine("1. Addition");
        Console.WriteLine("2. Subtraction");
        Console.WriteLine("3. Multiplication");
        Console.WriteLine("4. Division");

        Console.Write("Enter your choice: ");
        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.WriteLine("Result: " + Add(num1, num2));
                break;

            case 2:
                Console.WriteLine("Result: " + Subtract(num1, num2));
                break;

            case 3:
                Console.WriteLine("Result: " + Multiply(num1, num2));
                break;

            case 4:
                if (num2 != 0)
                {
                    Console.WriteLine("Result: " + Divide(num1, num2));
                }
                else
                {
                    Console.WriteLine("Cannot divide by zero.");
                }
                break;

            default:
                Console.WriteLine("Invalid choice.");
                break;
        }
    }
}
