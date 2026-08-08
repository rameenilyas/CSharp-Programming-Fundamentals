
using System;

class StudentProfile
{
    static void Main()
    {
        // Student Information
        string name = "Ali";
        int age = 20;
        string city = "Karachi";
        float marks = 85.5f;
        char grade = 'A';
        bool isPassed = true;

        // Constant
        const string university = "SMIU";

        // Display Student Profile
        Console.WriteLine("===== Student Profile =====");
        Console.WriteLine();

        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
        Console.WriteLine("City: " + city);
        Console.WriteLine("Marks: " + marks);
        Console.WriteLine("Grade: " + grade);
        Console.WriteLine("Passed: " + isPassed);
        Console.WriteLine("University: " + university);
    }
}
