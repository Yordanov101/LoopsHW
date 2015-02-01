using System;
class RandomizeTheNumbersOneToN
{
    // Write a program that enters in integer n and prints the numbers 1, 2, …, n in random order.
    // Example: n=3,	randomized numbers 1…n = 2 1 3.
    static void Main()
    {
        Console.Write("Please enter a number : ");
        int n = int.Parse(Console.ReadLine());

        int[] pool = new int[n];
        bool[] printed = new bool[n + 1];
        Random row = new Random();
        int random = row.Next(1, n + 1);

        for (int index = 0; index < n; index++)
        {
            random = row.Next(1, n + 1);
            if (!printed[random])
            {
                Console.Write("{0}", random);
                printed[random] = true;
            }
            else
            {
                index--;
            }
        }
        Console.WriteLine();
    }
}
