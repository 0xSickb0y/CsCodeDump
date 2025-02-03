# CsCodeDump
Personal repository dedicated to organizing C# source code, experiments, and cheat sheets. 

### Basic Program Structure
```csharp
// Every C# program starts with using directives
using System;

// Programs are organized into namespaces
namespace MyProgram
{
    // Main class
    class Program
    {
        // Entry point of the program
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
```

### Data Types
```csharp
// Common data types
int number = 10;           // Integer
string text = "Hello";     // String
bool flag = true;          // Boolean
double decimal = 10.5;     // Double
char letter = 'A';         // Character
var auto = "C#";          // Type inference with var
```

### Control Flow
```csharp
// If statements
if (condition)
{
    // code
}
else if (anotherCondition)
{
    // code
}
else
{
    // code
}

// Loops
for (int i = 0; i < 10; i++)
{
    // code
}

while (condition)
{
    // code
}

foreach (var item in collection)
{
    // code
}
```

### Collections
```csharp
// Arrays
string[] array = new string[5];
array[0] = "First";

// Lists
List<string> list = new List<string>();
list.Add("Item");

// Dictionary
Dictionary<string, int> dict = new Dictionary<string, int>();
dict["Key"] = 1;
```

### Methods
```csharp
// Method declaration
public int Add(int a, int b)
{
    return a + b;
}

// Method with optional parameter
public void Print(string message = "Default")
{
    Console.WriteLine(message);
}
```

### Classes
```csharp
public class Person
{
    // Properties
    public string Name { get; set; }
    public int Age { get; set; }

    // Constructor
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    // Method
    public void Introduce()
    {
        Console.WriteLine($"Hi, I'm {Name}");
    }
}
```

### Exception Handling
```csharp
try
{
    // Code that might throw an exception
    int result = 10 / 0;
}
catch (Exception ex)
{
    // Handle the exception
    Console.WriteLine(ex.Message);
}
finally
{
    // Always executed
}
```

### LINQ (Language Integrated Query)
```csharp
// LINQ examples
var numbers = new List<int> { 1, 2, 3, 4, 5 };

// Filter numbers
var evenNumbers = numbers.Where(n => n % 2 == 0);

// Order numbers
var ordered = numbers.OrderByDescending(n => n);

// Select/transform
var doubled = numbers.Select(n => n * 2);
```

### File Operations
```csharp
// Reading a file
string text = File.ReadAllText("file.txt");

// Writing to a file
File.WriteAllText("file.txt", "Hello World");

// Reading lines
string[] lines = File.ReadAllLines("file.txt");
```

### String Operations
```csharp
string text = "Hello World";
string upper = text.ToUpper();
string sub = text.Substring(0, 5);
bool contains = text.Contains("World");
string[] split = text.Split(' ');
```
