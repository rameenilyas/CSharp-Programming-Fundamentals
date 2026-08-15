using System;

class UserInputOutput
{
    static void Main()
    {
        // 1. User Input
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        Console.Write("Enter your age: ");
        int age = Convert.ToInt32(Console.ReadLine());


        // 2. Output
        Console.WriteLine();
        Console.WriteLine("Your name is: " + name);
        Console.WriteLine("Your age is: " + age);


        // 3. Multiple Inputs
        Console.WriteLine();

        Console.Write("Enter your roll number: ");
        int rollNumber = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter your marks: ");
        int marks = Convert.ToInt32(Console.ReadLine());


        // 4. Formatting Output
        Console.WriteLine();
        Console.WriteLine("--- Student Information ---");

        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Age: {age}");
        Console.WriteLine($"Roll Number: {rollNumber}");
        Console.WriteLine($"Marks: {marks}");
    }
}
