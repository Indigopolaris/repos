using System;

public class AccountTest
{
    public static void Main() // main method for user entry into the app 
    {
        Console.Write("Please enter the name of the account: "); //starts the application and collects info for the autoimplemented properties in the other class       
        string cusName = Console.ReadLine();
        Console.Write("Please enter the account number: ");
        int accNum = int.Parse(Console.ReadLine());
        Console.Write("Please enter the account type (C for commercial or R for Residential): "); 
        string Type = Console.ReadLine();
        Console.WriteLine("-------------------------------------------------------------------------");

        Account uIPage = new Account(cusName,accNum,Type); // account object connected to constructor

        if (Type == "C") //conditional statements to call each method based on whether the user enters C or R
        {
          uIPage.ComBill();
        }
        else if (Type == "R")
        {
            uIPage.ResBill();
        }
        
        
        uIPage.BillUI(); //calls the bill display method at the end
    }
}