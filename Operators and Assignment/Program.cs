using System;

class Program
{
    static void Main()
    {
        // Initialize variables
        int a = 10;
        int b = 20;

        // = (Assignment)
        a = b;
        Console.WriteLine("a = b; => a = " + a); // a = 20

        // += (Add and assign)
        a += b;
        Console.WriteLine("a += b; => a = " + a); // a = 30

        // -= (Subtract and assign)
        a -= b;
        Console.WriteLine("a -= b; => a = " + a); // a = -10

        // *= (Multiply and assign)
        a *= b;
        Console.WriteLine("a *= b; => a = " + a); // a = 200

        // /= (Divide and assign)
        a /= b;
        Console.WriteLine("a /= b; => a = " + a); // a = 0

        // %= (Modulus and assign)
        a %= b;
        Console.WriteLine("a %= b; => a = " + a); // a = 0 (10 % 20 = 10, but after division, a = 0)

        // ++ (Increment)
        a++;
        Console.WriteLine("a++; => a = " + a); // a = 1

        // -- (Decrement)
        a--;
        Console.WriteLine("a--; => a = " + a); // a = 0

        // Displaying the results of simple arithmetic operations
        int sum = a + b;
        int difference = a - b;
        int product = a * b;
        int quotient = a / b;
        int remainder = a % b;

        Console.WriteLine("a + b = " + sum); // 0 + 20 = 20
        Console.WriteLine("a - b = " + difference); // 0 - 20 = -20
        Console.WriteLine("a * b = " + product); // 0 * 20 = 0
        Console.WriteLine("a / b = " + quotient); // 0 / 20 = 0
        Console.WriteLine("a % b = " + remainder); // 0 % 20 = 0
    }
}
