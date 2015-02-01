using System;
class CalculateSomeNAndKFactorial
{
    //  write a program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100).
    // Try to use only two loops.
    // Examples:n=3,	k=2, 	n! / (k! * (n-k)!)=3
    static void Main()
    {
        Console.Write("Please enter a number (n) <100: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Please enter a number (k) < (n:) ");
        int k = int.Parse(Console.ReadLine());

        int product1 = 1;
        int product2 = 1;

        if (1 < k && k < n && n < 100)
        {
            for (int i = k + 1; i <= n; i++)
            {
                product1 *= i;
            }
            for (int j = 1; j <= (n-k); j++)
            {
                product2 = j;
            }           
        }
        else
        {
            Console.WriteLine("No valid input");
        }
        int result = product1/product2;
        Console.WriteLine("n! / (k! * (n-k)!)= {0}", result);
    }
}