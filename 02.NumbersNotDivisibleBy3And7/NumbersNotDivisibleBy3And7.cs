using System;
class NumbersNotDivisibleBy3And7
{
    // Write a program that enters from the console a positive integer (n) and prints all the numbers 
    // from 1 to (n) not divisible by 3 and 7, on a single line, separated by a space.
    // Examples : n=3,	output=1,2       n=10,     output=1 2 4 5 8 10.
    static void Main()
    {
        Console.WriteLine("Please enter a number:");
        int n = int.Parse(Console.ReadLine());
      
        for (int i = 1; i <= n; i++)
        {
            if (!(i % 3 == 0) && !(i % 7 == 0))
            {
                Console.WriteLine(i + " ");
            }
        }
    }
}
