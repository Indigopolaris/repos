using System;

public class InvoiceTest
{
    static void Main() // main method
    {
        Console.WriteLine("Student Name: William Slocum");  // opening messages and customer name object
        Console.WriteLine("Student ID: 800334994");
        Console.WriteLine("Please enter Customer Name:");
        string CustomerName = Console.ReadLine();
        Console.WriteLine($"Welcome {CustomerName} to Dave's Online Coffee Shop.");
        Invoice start = new Invoice(CustomerName);

        start.DisplayMessage(); // calls for each method
        start.AddItem();
        start.DisplayTotals();
    }

}
