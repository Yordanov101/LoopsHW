using System;
class CalculateGCD
{
    // Write a program that calculates the greatest common divisor (GCD) of given two integers a and b.
    // Use the Euclidean algorithm (find it in Internet).
    // Example : a=3,	b=2,	GCD(a, b)=1.
    static void Main()
    {
        Console.Write("Please enter the first number :");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Please enter the second number :");
        int b = int.Parse(Console.ReadLine());
        
        if (a < b)
        {
            a = a + b;
            b = a - b;
            a = a - b;
        }
        int divisor = (a % b);
        while (divisor != 0)
        {
            a = b;
            b = divisor;
            divisor = a % b;
        }
        Console.Write("The greatest common divisor of {0} and {1} is: ", a,b);
        Console.WriteLine("{0}", b);
    }
}
