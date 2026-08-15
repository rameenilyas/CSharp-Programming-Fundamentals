
## 💻 Mini Project: Student Registration System

Is project mein user se student ki information input li jayegi aur phir ek **formatted student profile** display hogi.

### Concepts Used

* `Console.ReadLine()`
* `Console.Write()`
* `Console.WriteLine()`
* `Convert.ToInt32()`
* Multiple Inputs
* String Interpolation `$"..."`

### User se input lena hai:

* Student Name
* Age
* Roll Number
* City
* Marks

### Example Output

```text
================================
      STUDENT REGISTRATION
================================

Enter Student Name: Ramee
Enter Age: 20
Enter Roll Number: 101
Enter City: Karachi
Enter Marks: 85

================================
       STUDENT PROFILE
================================

Name       : Ramee
Age        : 20
Roll Number: 101
City       : Karachi
Marks      : 85

================================
Registration Completed!
================================
```


//code
using System;

class StudentRegistrationSystem
{
    static void Main()
    {
        // Student Information Input

        Console.Write("Enter Student Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Roll Number: ");
        int rollNumber = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter City: ");
        string city = Console.ReadLine();

        Console.Write("Enter Marks: ");
        int marks = Convert.ToInt32(Console.ReadLine());


        // Formatted Output

        Console.WriteLine();
        Console.WriteLine("================================");
        Console.WriteLine("       STUDENT PROFILE");
        Console.WriteLine("================================");

        Console.WriteLine($"Name        : {name}");
        Console.WriteLine($"Age         : {age}");
        Console.WriteLine($"Roll Number : {rollNumber}");
        Console.WriteLine($"City        : {city}");
        Console.WriteLine($"Marks       : {marks}");

        Console.WriteLine("================================");
        Console.WriteLine("Registration Completed!");
        Console.WriteLine("================================");
    }
}
