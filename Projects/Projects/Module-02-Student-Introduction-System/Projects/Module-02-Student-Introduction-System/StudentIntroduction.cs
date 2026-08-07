
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("===== Student Introduction System =====");
        Console.WriteLine();

        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        Console.Write("Enter your age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter your city: ");
        string city = Console.ReadLine();

        Console.Write("Enter your course: ");
        string course = Console.ReadLine();

        Console.WriteLine();
        Console.WriteLine("===== Student Information =====");

        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
        Console.WriteLine("City: " + city);
        Console.WriteLine("Course: " + course);

        Console.WriteLine();
        Console.WriteLine("Thank you for using Student Introduction System!");

        Console.ReadKey();
    }
}
