
using System.Text;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        var firstName = "john";
        var lastName = string.Empty;

        Console.WriteLine(firstName + " " + lastName);  // string concatenation

        lastName = "doe";

        Console.WriteLine(firstName + " " + lastName);

        var firstNumber = "100";
        var secondNumber = "200";

        Console.WriteLine(firstNumber + secondNumber);  // returns 100200
    
        var fullName = string.Concat(firstName, " ", lastName);
        Console.WriteLine(fullName);

        var ciaTriad = new StringBuilder();
        ciaTriad.AppendLine("");
        ciaTriad.AppendLine("Confidentiality, Integrity, and Availability");

        Console.WriteLine(ciaTriad.ToString());

        var cartTotal = 108.73912F;

        Console.WriteLine($"Using \"F2\": {cartTotal:F2}\n");  // returns 108.74

        Console.WriteLine("Currency formatting:");

        CultureInfo.CurrentCulture = new CultureInfo("en-US");  // sets the culture to US
        Console.WriteLine($"USA: {cartTotal:C2}");  // returns $108.74

        CultureInfo.CurrentCulture = new CultureInfo("de-DE");  // sets the culture to Germany
        Console.WriteLine($"Germany: {cartTotal:C2}\n");  // returns 108,74 €\

        Console.WriteLine($"As a number: {cartTotal:N2}");

        Console.WriteLine("This is a backslash: \\");
        Console.WriteLine("This is a single quote: \'");
        Console.WriteLine("This is a double quote: \"");
        Console.WriteLine("This is the end of the first line:\nSecond line below because of the \"\\n\" escape sequence.");
        Console.WriteLine("This is a carriage return:\rThis text will overwrite the previous text, so you will not see \"This is a carriage return:\".");
        Console.WriteLine("This is a tab:\tTabbed text here.");
        Console.WriteLine("This is a backspace: b\bNote that the \"b\" character is missing!");
        Console.WriteLine("This is a form feed:\fForm feed is used to signal a new page, this doesn't not show up in a Console application.");
    }
}