using System;

class Program
{
    static void Main()
    {
        // Using a for loop to print numbers from 1 to 5
        Console.WriteLine("Using for loop:");
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine(i);
        }

        // Using a while loop to print numbers from 1 to 5
        Console.WriteLine("\nUsing while loop:");
        int j = 1;
        while (j <= 5)
        {
            Console.WriteLine(j);
            j++;
        }

        // Using a do-while loop to print numbers from 1 to 5
        Console.WriteLine("\nUsing do-while loop:");
        int k = 1;
        do
        {
            Console.WriteLine(k);
            k++;
        } while (k <= 5);
    }
}
