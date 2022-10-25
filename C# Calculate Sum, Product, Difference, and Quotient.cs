//Unit 1 Graded exercise 2
using System;

class Addition
{
        //Main method begins execution of C# app
        static void Main()
    {
        int number1; //delcare first number to add
        int number2; //delcare second number to add
        int sum; // declare sum of number1 and number2

        Console.Write("Enter first integer: "); // prompt user
        // read first number from user
        number1 = int.Parse(Console.ReadLine());

        Console.Write("Enter second integer: "); // prompt user
        // read second number from user
        number2 = int.Parse(Console.ReadLine());

        sum = number1 + number2; // add numbers
        sum = number1 * number2; // multiply numbers
        sum = number1 - number2; // subtract numbers


        Console.WriteLine($"Sum is {number1 + number2}"); // display sum
        Console.WriteLine($"Sum is {number1 * number2}"); // display product
        Console.WriteLine($"Sum is {number1 - number2}"); // display difference
    } // end Main
} // end class Addition