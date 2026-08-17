using System;

class NestedIf
{
    static void Main()
    {
        int age = 20;
        bool hasID = true;

        if (age >= 18)
        {
            if (hasID)
            {
                Console.WriteLine("Entry allowed.");
            }
        }
    }
}
