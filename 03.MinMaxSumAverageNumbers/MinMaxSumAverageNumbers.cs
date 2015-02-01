using System;
class MinMaxSumAverageNumbers
{
    // Write a program that reads from the console a sequence of (n) integer numbers and returns the 
    // minimal,the maximal number, the sum and the average of all numbers (displayed with 2 digits after
    // the decimal point).The input starts by the number n (alone in a line) followed by n lines, each 
    // holding an integer number.
    // Examples : input= 3,2,5,1.	output: min=1  max=5  sum=8  avg=2,67.
    static void Main()
    {
        Console.Write("Please enter how many numbers will be the sequence: ");
        int count = int.Parse(Console.ReadLine());

        int inputNumber;
        int sum = 0;
        int maxValue = int.MinValue;
        int minValue = int.MaxValue;

        for (int i = 1; i <= count; i++)
        {
            Console.Write("Enter the {0} number: ", i);
            inputNumber = int.Parse(Console.ReadLine());

            sum += inputNumber;
            if (inputNumber > maxValue)
            {
                maxValue = inputNumber;
            }
            if (inputNumber < minValue)
            {
                minValue = inputNumber;
            }
        }
        double average = (double)sum / (double)count;
        Console.WriteLine("max = {0}\nmin = {1}\nsum = {2 :F2}\navg = {3 :F2}",maxValue,minValue,sum,average);
    }
}