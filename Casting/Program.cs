
internal class Program
{
    private static void Main(string[] args)
    {
        int intValue = 42;
        double doubleValue = intValue; // Implicit conversion from int to double
        Console.WriteLine($"Implicit conversion: int {intValue} to double {doubleValue}");

        double doubleValue2 = 42.58;
        int intValue2 = (int)doubleValue2; // Explicit conversion from double to int
        Console.WriteLine($"Explicit conversion: double {doubleValue2} to int {intValue2}");

        string stringValue = "123";
        int intValue3 = int.Parse(stringValue); // Attempting explicit conversion
        Console.WriteLine($"Parsed int: {intValue3}");

        try
        {
            string stringValue2 = "123.45";
            int intValue4 = int.Parse(stringValue2); // Attempting explicit conversion
            Console.WriteLine($"Parsed int: {intValue4}");
        }
        catch (FormatException e)
        {
            Console.WriteLine($"Conversion failed: {e.Message}");
        }

    }
}