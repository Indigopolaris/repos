using System;

public class TransactionTest
{

    public static void Main()
    {
        Console.WriteLine("Please enter your name: ");
        string userName = Console.ReadLine();

        Transaction usern = new Transaction(userName);

        Console.WriteLine($"Welcome {userName} to the ACME corporations product shop!");

        usern.ProductShop();
        usern.CustomerCart();
        usern.CustomerSubtotal();

    }
}
