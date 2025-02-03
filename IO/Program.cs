internal class Program
{
    private static void Main(string[] args)
    {
        // Using Console.Write
        Console.Write("Hello, ");
        Console.Write("World!");  // Output: Hello, World! - there is no line break between "Hello, " and "World!"
    
        Console.Write("\n");

        // Using Console.WriteLine
        Console.WriteLine("Hello, World!");
        Console.WriteLine("I'm writing C# code!");  // with Console.WriteLine, there is a line break after each call
    
        // Using string interpolation with Console.WriteLine
        var name = "John";  // string variable
        Console.WriteLine($"Hello, {name}!");

        Console.WriteLine("Enter your name: ");
        var input = Console.ReadLine();  // the system waits for input, and stores the result in the name variable.
        Console.WriteLine($"Hello, {input}");

        if (args.Length > 0)
        {
            Console.WriteLine("Command line arguments:");
            foreach (string arg in args)
            {
                Console.WriteLine(arg);
            }
        }
        else
        {
            Console.WriteLine("No command line arguments were provided.");
        }
    }
}