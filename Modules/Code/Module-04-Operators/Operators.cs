using System;

class Operators
{
    static void Main()
    {
        // Arithmetic Operators
        int a = 10;
        int b = 3;

        Console.WriteLine("Arithmetic Operators");

        Console.WriteLine("Addition: " + (a + b));
        Console.WriteLine("Subtraction: " + (a - b));
        Console.WriteLine("Multiplication: " + (a * b));
        Console.WriteLine("Division: " + (a / b));
        Console.WriteLine("Remainder: " + (a % b));


        // Assignment Operators
        int x = 10;

        Console.WriteLine("\nAssignment Operators");

        Console.WriteLine("Original x: " + x);

        x += 5;
        Console.WriteLine("After += 5: " + x);

        x -= 3;
        Console.WriteLine("After -= 3: " + x);
    }
}

// Comparison Operators
Console.WriteLine("\nComparison Operators");

Console.WriteLine("a == b: " + (a == b));
Console.WriteLine("a != b: " + (a != b));
Console.WriteLine("a > b: " + (a > b));
Console.WriteLine("a < b: " + (a < b));
Console.WriteLine("a >= b: " + (a >= b));
Console.WriteLine("a <= b: " + (a <= b));

// Logical Operators
bool isStudent = true;
bool hasID = false;

Console.WriteLine("\nLogical Operators");

Console.WriteLine("AND (&&): " + (isStudent && hasID));
Console.WriteLine("OR (||): " + (isStudent || hasID));
Console.WriteLine("NOT (!): " + (!isStudent));

// Increment and Decrement Operators
int number = 5;

Console.WriteLine("\nIncrement / Decrement Operators");

Console.WriteLine("Original: " + number);

number++;
Console.WriteLine("After ++: " + number);

number--;
Console.WriteLine("After --: " + number);
