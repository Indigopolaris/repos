
using System;

// William Slocum Mist 352 Assignment 1 Part 1

public class OddOrEven
{
    public static void Main()
    {
        int num1; 

        Console.WriteLine("Please enter an Integer");

        num1 = int.Parse(Console.ReadLine()); //accepts integer from the user 

        int remainder = num1 % 2; // divides number to display if there is a remainder

        if (remainder > 0)
        {
            Console.WriteLine("The Integer is Odd."); // if remainder then the number is odd 
        }
        

        if (remainder == 0)
        {
            Console.WriteLine("The Integer is Even."); // if no remainder then number is even
        }
        

    }
}
