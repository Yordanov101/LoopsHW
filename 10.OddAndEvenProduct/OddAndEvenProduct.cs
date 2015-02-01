using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class OddAndEvenProduct
{
    // You are given (n) integers (given in a single line, separated by a space).
    // Write a program that checks whether the product of the odd elements is equal to the product of the 
    // even elements.Elements are counted from 1 to n, so the first element is odd, the second is even, etc.
    // Example : numbers= 2 1 1 6 3,	result=yes.
    static void Main()
    {
        Console.WriteLine("Please enter numbers in a single line, separated by a space and select Enter: ");
        string numbers = Console.ReadLine();
        int[] arr = numbers.Split(' ').Select(n => Convert.ToInt32(n)).ToArray();

        int oddResult = 1;
        int evenResult = 1;
        for (int i = 0; i < arr.Length; i++)
        {
            if (i % 2 == 0) 
            {
                oddResult *= arr[i];
            } 
            else evenResult *= arr[i];
        }

        if (oddResult == evenResult)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}
