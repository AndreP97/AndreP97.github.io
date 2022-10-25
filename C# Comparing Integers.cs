
using System;

public class Larger
{
    public static void Main(string[] args)
    {
        int number1; // first number to compare
        int number2; // second number to compare

        // prompt for input and read first number
        Console.Write("Enter first integer: ");
        number1 = Convert.ToInt32(Console.ReadLine());

        // prompt for input and read second number
        Console.Write("Enter second integer: ");
        number2 = Convert.ToInt32(Console.ReadLine());

        // determine whether number1 is greater than number2
        if (number1 > number2)
            Console.WriteLine("{0} is larger", number1);

        // determine whether number1 is less than number2
        if (number1 < number2)
            Console.WriteLine("{0} is larger", number2);

        // determine whether number1 is equal to number2
        if (number1 == number2)
            Console.WriteLine("These numbers are equal");
    } // end Main
} // end class Larger