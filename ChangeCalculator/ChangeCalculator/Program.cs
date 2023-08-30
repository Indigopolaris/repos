using System;
// William Slocum Mist352 Assignment 1 part 3 "Change Calculator"
public class ChangeCalulator
{
    public static void Main()
    {
        decimal price; 
        Console.Write("Item price is: $");
        price = decimal.Parse(Console.ReadLine());
        // user inputs price.

        decimal tender;
        Console.Write("Amount tended: $");
        tender = decimal.Parse(Console.ReadLine());
        //user inputs tender.

        decimal change; 
        change = tender - price;
        Console.Write("your change is: $" + change);
        Console.WriteLine(""); // added space
        Console.WriteLine("");
        // change is amount tended minus the price.

        int dollars = (int)change; // drops decimal from change to display dollars

        Console.WriteLine("dollars: " + dollars);

        decimal cents = change - dollars; // displays the decimal portion of change as cents

        decimal centsasint; // cents into integer for further disection of each coin type needed
        centsasint = cents * 100; 
        int qscaleup; 
        qscaleup = (int)centsasint / 25; // divides cents into amount of quarters
        Console.WriteLine("quarters: " + qscaleup);

        int n1; // place holder values for remaining change
        int n2;
        int n3;
        int n4;
        int n5;
        int n6;

        n1 = qscaleup * 25;  
        n2 = (int)centsasint - n1;
        n3 = n2 / 10; //divides remaining cents into portions of dimes
        Console.WriteLine("dimes: " + n3);

        n4 = n2 - 10 * n3;
        n5 = n4 / 5; // divides remaining cents into nickles
        Console.WriteLine("Nickles: " + n5); 

        n6 = n4 - 5 * n5; //leftover decimal amount is represented as pennies
        Console.WriteLine("pennies: " + n6); 

    }

}
