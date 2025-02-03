
using System.Reflection.Metadata;
using Domain;

internal class Program
{
    private static void Main(string[] args)
    {
        var a = new Dog("Alice", 8);
        var b = new Dog("Bob", 10);
        var c = new Dog("Chalie", 15);

        Console.WriteLine(a.Bark());
        Console.WriteLine(b.ShowHumanAge());

        Console.WriteLine(c.Bark());
        Console.WriteLine(c.ShowHumanAge());

    }
}