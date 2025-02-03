using System;

class Program
{
    static void Main()
    {
        // Flow conditions with if-else
        int number = 15;

        // If-else condition
        if (number > 0)
        {
            Console.WriteLine("The number is positive.");
        }
        else if (number < 0)
        {
            Console.WriteLine("The number is negative.");
        }
        else
        {
            Console.WriteLine("The number is zero.");
        }

        // Flow conditions with switch-case
        string day = "Monday";

        switch (day)
        {
            case "Monday":
                Console.WriteLine("Start of the workweek!");
                break;
            case "Friday":
                Console.WriteLine("End of the workweek!");
                break;
            case "Saturday":
            case "Sunday":
                Console.WriteLine("It's the weekend!");
                break;
            default:
                Console.WriteLine("It's a regular weekday.");
                break;
        }
    }
}
