using System;
using System.IO;

class Program
{
    static void Main()
    {
        // File paths (Make sure the file path is correct or it exists)
        string filePath = "sample.txt";

        // Writing to a file
        try
        {
            Console.WriteLine("Writing to the file...");

            // Use StreamWriter to write to the file
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine("Hello, World!");
                writer.WriteLine("This is a test file.");
                writer.WriteLine("Writing to files is easy with C#.");
            }

            Console.WriteLine("File written successfully!");

        }
        catch (Exception ex)
        {
            Console.WriteLine("Error writing to the file: " + ex.Message);
        }

        // Reading from a file
        try
        {
            Console.WriteLine("\nReading from the file...");

            // Use StreamReader to read from the file
            if (File.Exists(filePath))
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            else
            {
                Console.WriteLine("File not found!");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error reading the file: " + ex.Message);
        }

        // Appending to the file
        try
        {
            Console.WriteLine("\nAppending to the file...");

            // Use StreamWriter to append to the file
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine("This is an appended line.");
                writer.WriteLine("Appending to files is also simple in C#!");
            }

            Console.WriteLine("File appended successfully!");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error appending to the file: " + ex.Message);
        }

        // Reading the file again to show the appended content
        try
        {
            Console.WriteLine("\nReading the updated file...");

            if (File.Exists(filePath))
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            else
            {
                Console.WriteLine("File not found!");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error reading the file: " + ex.Message);
        }
    }
}
