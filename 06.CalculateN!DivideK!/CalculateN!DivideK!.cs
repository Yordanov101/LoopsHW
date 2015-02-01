using System;
class CalculateNDivideK
{
    // Write a program that calculates n! / k! for given n and k (1 < k < n < 100).
    // Use only one loop.
    // Examples: n=5,	k=2,	n! / k! =60
    static void Main()
    {
        Console.Write("Please enter a number (n) <100: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Please enter a number (k) < (n:) ");
        int k = int.Parse(Console.ReadLine());

        int sum = 1;
        if (1 < k && k < n && n < 100)
        {
            for (int i = k+1; i <=n; i++)
            {
                sum*=i;
            }   
        }
       else
        {
            Console.WriteLine("No valid input");
        }
        Console.WriteLine("n!/k! = {0}", sum);
    }
}
