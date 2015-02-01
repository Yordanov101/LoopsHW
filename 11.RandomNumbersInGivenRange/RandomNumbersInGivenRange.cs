using System;
class RandomNumbersInGivenRange
{
    // Write a program that enters 3 integers n, min and max (min != max) and prints n random numbers in
    // the range [min...max].
    //Example : n=5,	min=0,	max=1,	random numbers=1 0 0 1 1.
    static void Main()
    {
        Console.Write("Please enter a number n > 1: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter minimal value: ");
        int min = int.Parse(Console.ReadLine());
        Console.Write("Enter maximal value(max != min): ");
        int max = int.Parse(Console.ReadLine());

        Random row = new Random();
        for (int i = 1; i <= n; i++)
        {
            Console.Write("{0} ", row.Next(min, max + 1));
        }
    }
}
