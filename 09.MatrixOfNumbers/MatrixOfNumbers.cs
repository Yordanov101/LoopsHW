using System;

class MatrixOfNumbers
{
    // Write a program that reads from the console a positive int. number n (1≤ n≤ 20)and prints a matrix.
    // Examples: n=2  matrix 12      n=3    matrix  123 
    //                       23                     234
    //                                              345
    static void Main()
    {
        Console.Write("Please enter a number (1<=20): ");
        int n = int.Parse(Console.ReadLine());

        if (n > 0 && n <= 20)
        {
            for (int row = 1; row <= n; row++)
            {
                for (int coll = 0; coll < n; coll++)
                {
                    Console.Write("{0,2} ", coll+row);
                }
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine(" No valid input number ");
        }
    }
}
