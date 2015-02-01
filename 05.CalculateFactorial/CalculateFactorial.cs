using System;
class CalculateFactorial
{
    // Write a program that, for a given two integer numbers n and x, 
    // calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/x^n.
    // Use only one loop. Print the result with 5 digits after the decimal point.
    // Example: n=3,	x=2,	S=2,75000
    static void Main()
    {
        Console.Write("Please enter a number (n): ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Please enter a number (x): ");
        int x = int.Parse(Console.ReadLine());

        double xAtPowerN = 1;
        double factorial = 1;
        double sum = 1;

        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
            xAtPowerN *= x;
            sum += (factorial / xAtPowerN);
        }
        Console.WriteLine("Sum is : {0:F5}", sum);
    }
}