using System;

class NumberAnalyzer
{
    static void Main()
    {
        Console.Write("How many numbers do you want to enter? ");
        int count = Convert.ToInt32(Console.ReadLine());

        int positive = 0;
        int negative = 0;
        int zero = 0;
        int sum = 0;

        for (int i = 1; i <= count; i++)
        {
            Console.Write("Enter number " + i + ": ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number > 0)
            {
                positive++;
            }
            else if (number < 0)
            {
                negative++;
            }
            else
            {
                zero++;
            }

            sum += number;
        }

        Console.WriteLine("\n--- Results ---");
        Console.WriteLine("Positive numbers: " + positive);
        Console.WriteLine("Negative numbers: " + negative);
        Console.WriteLine("Zero numbers: " + zero);
        Console.WriteLine("Total sum: " + sum);
    }
}
