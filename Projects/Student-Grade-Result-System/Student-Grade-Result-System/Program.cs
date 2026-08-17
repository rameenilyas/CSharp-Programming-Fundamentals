using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter student name: ");
        string name = Console.ReadLine();

        Console.Write("Enter marks: ");
        int marks = Convert.ToInt32(Console.ReadLine());

        string grade;

        if (marks >= 80)
        {
            grade = "A";
        }
        else if (marks >= 70)
        {
            grade = "B";
        }
        else if (marks >= 60)
        {
            grade = "C";
        }
        else if (marks >= 50)
        {
            grade = "D";
        }
        else
        {
            grade = "F";
        }

        Console.WriteLine("\n--- Student Result ---");
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Marks: " + marks);
        Console.WriteLine("Grade: " + grade);

        if (marks >= 50)
        {
            Console.WriteLine("Result: Pass");
        }
        else
        {
            Console.WriteLine("Result: Fail");
        }
    }
}
