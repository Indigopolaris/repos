using System;
// William Slocum Mist352 Assignment 1 part 3 "Value Of Coins"
public class ChangeCalulator
{
    public static void Main()
    {
        int dol = 1;  // local varibles to set values of each type of money used
        double q = .25;
        double d = .10;
        double n = .05;
        double p = .01;

        int numofdol; //local varibles used to count each instance of each currency type inputed by user
        int numofq;
        int numofd;
        int numofn;
        int numofp;

        Console.WriteLine("Please enter number of dollars tended:"); //statements to request user input, then accept number of each currency type
        numofdol = int.Parse(Console.ReadLine());

        Console.WriteLine("Please enter number of quarters tended:");
        numofq = int.Parse(Console.ReadLine());

        Console.WriteLine("Please enter number of dimes tended:");
        numofd = int.Parse(Console.ReadLine());

        Console.WriteLine("Please enter number of nickles tended:");
        numofn = int.Parse(Console.ReadLine());

        Console.WriteLine("Please enter number of pennies tended:");
        numofp = int.Parse(Console.ReadLine());

        int dolchg = numofdol * dol; // local varibles that calculate total amt of each currency type
        double qchg = numofq * q;
        double dchg = numofd * d;
        double nchg = numofn * n;
        double pchg = numofp * p;

        double totcents = qchg + dchg + nchg + pchg; //calculates total cents, then we display a statement to confirm what the user entered
        Console.WriteLine($"Total change entered is {dolchg} dollars and {totcents} worth of cents");

        Console.WriteLine($"The Amount of U.S. currency entered is: ${totcents + dolchg}"); //displays change entered

        double preconvert = totcents + dolchg; //var to create the number of total change entered 
        decimal convertGBP = (decimal)preconvert * 0.73M; //var to convert total change to GBP
        Console.WriteLine($" The Conversion is: £{convertGBP} "); //displays converted amt for the user

    }

}