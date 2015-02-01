using System;
class CatalanNumbers
{
    // Write a program to calculate the n-th Catalan number by given n (0 ≤ n ≤ 100).
    // Formula is: (2N)! / (N+1)! * N!
    // Example : n=0,	Catalan(n)=1;     n=5,    Catalan(n)=42; 
    static void Main()
    {
        Console.Write("Please enter a Catalan number (n):");
        int n = int.Parse(Console.ReadLine());

        int factorialN = 1;
        int divider = 1;
        if (n > 0 && n < 100)
        {
            for (int i = 2 * n; i > n + 1; i--)
            {
                factorialN *= i;
            }
            for (int i = 1; i <= n; i++)
            {
                divider *= i;
            }
            int result = factorialN / divider;
            Console.WriteLine("The Catalan number is: {0}", result);
        }
        else
        {
            Console.WriteLine("The number must be bigger than zero");
        }
    }
}
