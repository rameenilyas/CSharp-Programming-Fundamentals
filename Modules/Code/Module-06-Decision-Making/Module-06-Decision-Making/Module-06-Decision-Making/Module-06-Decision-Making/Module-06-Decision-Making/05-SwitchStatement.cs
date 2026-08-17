using System;

class SwitchStatement
{
    static void Main()
    {
        int day = 2;

        switch (day)
        {
            case 1:
                Console.WriteLine("Monday");
                break;

            case 2:
                Console.WriteLine("Tuesday");
                break;

            case 3:
                Console.WriteLine("Wednesday");
                break;

            default:
                Console.WriteLine("Invalid day");
                break;
        }
    }
}
