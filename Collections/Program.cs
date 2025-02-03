using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // List Example
        Console.WriteLine("List Example:");

        List<string> fruits = new List<string> { "Apple", "Banana", "Cherry", "Date" };
        fruits.Add("Elderberry");  // Adding a new element to the list
        fruits.Remove("Banana");   // Removing an element from the list

        Console.WriteLine("Fruits List:");
        foreach (var fruit in fruits)
        {
            Console.WriteLine(fruit);
        }

        // Dictionary Example
        Console.WriteLine("\nDictionary Example:");

        Dictionary<int, string> students = new Dictionary<int, string>
        {
            { 101, "Alice" },
            { 102, "Bob" },
            { 103, "Charlie" }
        };

        // Adding a new key-value pair
        students.Add(104, "David");

        // Checking if a key exists
        if (students.ContainsKey(102))
        {
            Console.WriteLine("Student ID 102: " + students[102]);
        }

        // Iterating through the dictionary
        Console.WriteLine("All students:");
        foreach (var student in students)
        {
            Console.WriteLine($"ID: {student.Key}, Name: {student.Value}");
        }

        // Array Example
        Console.WriteLine("\nArray Example:");

        int[] numbers = { 1, 2, 3, 4, 5 };
        
        // Accessing array elements
        Console.WriteLine("Array values:");
        foreach (var number in numbers)
        {
            Console.WriteLine(number);
        }

        // Modifying an array element
        numbers[2] = 10;  // Change the 3rd element to 10
        Console.WriteLine("\nModified Array:");
        foreach (var number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}
