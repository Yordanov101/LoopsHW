using System;
class NumbersFromOneToN
{
    // Write a program that enters from the console a positive integer n and prints all the numbers 
    // from 1 to n, on a single line, separated by a space.
    // Example: n=3	output=1 2 3.
    static void Main()
    {
        Console.WriteLine("Please enter a number;");
        int n = int.Parse(Console.ReadLine());
        int counter = 1;
        while (counter <= n)
        {
            Console.Write(counter + " ");
            counter++;
        }
    }
}
