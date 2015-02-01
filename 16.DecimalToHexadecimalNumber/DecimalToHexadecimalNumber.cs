using System;
class DecimalToHexadecimalNumber
{
    // Using loops write a program that converts an integer number to its hexadecimal representation.
    // The input is entered as long. The output should be a variable of type string.
    // Do not use the built-in .NET functionality.
    // Example: decimal=254,	hexadecimal=FE.
    static void Main()
    {
        Console.Write("Please enter a number in decimal format: " );
            int decValue = int.Parse(Console.ReadLine());
            string hexValue = decValue.ToString("X");
            {
                Console.WriteLine("hexadecimal output : " + hexValue);
            }     
    }
}
