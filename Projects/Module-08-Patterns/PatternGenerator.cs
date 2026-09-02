using System;

class PatternGenerator
{
    static void Main()
    {
        int choice;

        do
        {
            Console.WriteLine("===== Pattern Generator =====");
            Console.WriteLine("1. Square Pattern");
            Console.WriteLine("2. Right Triangle Pattern");
            Console.WriteLine("3. Inverted Triangle Pattern");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");

            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    for (int i = 1; i <= 5; i++)
                    {
                        for (int j = 1; j <= 5; j++)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine();
                    }
                    break;

                case 2:
                    for (int i = 1; i <= 5; i++)
                    {
                        for (int j = 1; j <= i; j++)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine();
                    }
                    break;

                case 3:
                    for (int i = 5; i >= 1; i--)
                    {
                        for (int j = 1; j <= i; j++)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine();
                    }
                    break;

                case 4:
                    Console.WriteLine("Goodbye!");
                    break;

                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }

            Console.WriteLine();

        } while (choice != 4);
    }
}
