

internal class Program
{
    private static void Main(string[] args)
    {
        var cart = 99.99F;
        var tax = 0.0875F;
        var taxTotal = 99.99 * cart * tax;
        var final = cart + taxTotal;

        Console.WriteLine($"Cart ammount: {cart}");
        Console.WriteLine($"Tax: {tax}: {taxTotal}");
        Console.WriteLine($"Total Ammount: {final}");
    }
}