using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Student Percentage System ===");

        // Input student name
        Console.Write("Enter Student Name: ");
        string name = Console.ReadLine();

        // Input marks
        Console.WriteLine("Enter marks of 5 subjects:");

        int m1 = int.Parse(Console.ReadLine());
        int m2 = int.Parse(Console.ReadLine());
        int m3 = int.Parse(Console.ReadLine());
        int m4 = int.Parse(Console.ReadLine());
        int m5 = int.Parse(Console.ReadLine());

        // Calculate total
        int total = m1 + m2 + m3 + m4 + m5;

        // Calculate percentage
        double percentage = (total / 500.0) * 100;

        // Output result
        Console.WriteLine("\n--- Result ---");
        Console.WriteLine("Student Name: " + name);
        Console.WriteLine("Total Marks: " + total);
        Console.WriteLine("Percentage: " + percentage + "%");

        Console.WriteLine("\nThank you!");
    }
}
