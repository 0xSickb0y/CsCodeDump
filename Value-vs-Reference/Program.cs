using System;

public class Person {
    public string Name { get; set; } = string.Empty;
    public int Age { get; set; }

    public Person(string name, int age) {
        Name = name;
        Age = age;
    }
}

class Program {
    static void Main() {
        // Stack variable, value type
        var age = 100; 
        Console.WriteLine(age); // 100

        age = 50;  // 100 is replaced by 50 on the stack
        Console.WriteLine(age); // 50

        // Heap object, reference type
        var alex = new Person("Alex", 50); 
        Console.WriteLine($"alex object: {alex.Name} is {alex.Age} years old."); 

        var john = new Person("John", 30); 
        Console.WriteLine($"john object: {john.Name} is {john.Age} years old."); 

        // Updating alex's Age
        alex.Age = 25; // 50 is replaced by 25 on the heap for the 'alex' object
        Console.WriteLine($"alex object after age update: {alex.Name} is {alex.Age} years old."); 

        // Assigning one object reference to another
        alex = john; // alex now points to the same object as john
        Console.WriteLine($"alex object after being set equal to john: {alex.Name} is {alex.Age} years old."); 

        // Updating the age will affect both alex and john since they point to the same object
        alex.Age = 40; // 30 is replaced by 40 on the heap for both alex and john
        Console.WriteLine($"alex object after age update: {alex.Name} is {alex.Age} years old."); 
        Console.WriteLine($"john object: {john.Name} is {john.Age} years old."); 

        // Updating john's Age
        john.Age = 100;
        Console.WriteLine($"alex object: {alex.Name} is {alex.Age} years old."); 
        Console.WriteLine($"john object: {john.Name} is {john.Age} years old."); 

        // Demonstrating value type passed by reference
        var number = 100;
        Console.WriteLine(number); // 100

        MultiplyByTwo(ref number);

        Console.WriteLine($"number outside of method: {number}"); // 200
    }

    // Method that modifies the value type passed by reference
    private static void MultiplyByTwo(ref int number)
    {
        Console.WriteLine($"number passed to method: {number}"); // 100
        number *= 2;
        Console.WriteLine($"number * 2: {number}"); // 200
    }
}
