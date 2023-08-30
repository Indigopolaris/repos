using System;

//William Slocum mist 352 Assignment 1 Part 2 "multiples"
public class Multiples
{
  public static void Main()
    {
        Console.WriteLine("Please provide the first integer.");

        int num1;
        num1 = int.Parse(Console.ReadLine());  // accepts first integer from user

        Console.WriteLine("Please provide the second integer.");

        int num2;
        num2 = int.Parse(Console.ReadLine()); // accepts second integer from user

        int multiple;
        multiple = num1 % num2; // divides first and second integer 

        if (multiple == 0) // displays that the first integer is a multiple of the second
        {
            Console.WriteLine("The first number is a multiple of the second.");
        }

        if (multiple > 0) //displays that the first integer is not a multiple of the second
        {
          Console.WriteLine("The first number is not a multiple of the second");
        }
           

    }

}
