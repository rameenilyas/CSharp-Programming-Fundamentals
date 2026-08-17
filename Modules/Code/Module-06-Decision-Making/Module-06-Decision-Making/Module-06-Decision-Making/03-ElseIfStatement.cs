using System;

class ElseIfStatement
{
    static void Main()
    {
        int marks = 75;

        if (marks >= 80)
        {
            Console.WriteLine("A Grade");
        }
        else if (marks >= 70)
        {
            Console.WriteLine("B Grade");
        }
        else if (marks >= 60)
        {
            Console.WriteLine("C Grade");
        }
        else
        {
            Console.WriteLine("Fail");
        }
    }
}
