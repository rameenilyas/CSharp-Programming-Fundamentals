
using System;

class Program
{
    static void Main()
    {
        // Student Information
        Console.WriteLine("===== Student Result Calculator =====");

        Console.Write("Enter Student Name: ");
        string studentName = Console.ReadLine();

        // Enter Marks
        Console.Write("Enter marks for Subject 1: ");
        double subject1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter marks for Subject 2: ");
        double subject2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter marks for Subject 3: ");
        double subject3 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter marks for Subject 4: ");
        double subject4 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter marks for Subject 5: ");
        double subject5 = Convert.ToDouble(Console.ReadLine());

        // Calculate Total and Percentage
        double totalMarks = subject1 + subject2 + subject3 + subject4 + subject5;
        double percentage = (totalMarks / 500) * 100;

        // Calculate Grade
        string grade;

        if (percentage >= 80)
        {
            grade = "A";
        }
        else if (percentage >= 70)
        {
            grade = "B";
        }
        else if (percentage >= 60)
        {
            grade = "C";
        }
        else if (percentage >= 50)
        {
            grade = "D";
        }
        else
        {
            grade = "F";
        }

        // Pass / Fail
        string result;

        if (percentage >= 50)
        {
            result = "Pass";
        }
        else
        {
            result = "Fail";
        }

        // Display Result
        Console.WriteLine();
        Console.WriteLine("===== Student Result =====");
        Console.WriteLine("Student Name: " + studentName);
        Console.WriteLine("Total Marks: " + totalMarks + " / 500");
        Console.WriteLine("Percentage: " + percentage + "%");
        Console.WriteLine("Grade: " + grade);
        Console.WriteLine("Result: " + result);

        Console.WriteLine("==========================");
    }
}
