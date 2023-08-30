using System;
public class AccountTest
{
    public static void Main()
    {
        Console.WriteLine("Please enter the name for the new account: ");
        string AccHolderName = Console.ReadLine();

        Console.WriteLine("Please enter the ititial balance for the new account: ");
        decimal initBalance = decimal.Parse(Console.ReadLine());


        Account myAcc1 = new Account("mrWorldWide", 100.01m); // add string and dec for constructor

        Console.WriteLine("the name of the account holder is: " + myAcc1.GetName());

        Console.WriteLine($"the intitial balance of the account is: {myAcc1.Balance}");
        //objectName.MethodName() to call a method that sits in another class

        // the format to invoke a method that is located
        // in another class is objectName.MethodName()

        //myAcc1.SetName("William Slocum");  THIS OR NEXT ONE

        myAcc1.Name = "William Slocum";// the set portion of the name property is being used to assign val to instance var

        //myAcc1.SetBalance(500.55m); //No longer needed 
        myAcc1.Balance = 500.55m;

        Console.WriteLine("the name of the account holder after it has been updated is: " + myAcc1.GetName());
        
        Console.WriteLine("the updated balance is: " + myAcc1.Balance);

        //create another account
        Console.Write("please enter the name for the new account: ");
        AccHolderName = Console.ReadLine();

        Console.Write("Please enter the initial amount for the new account: ");
        initBalance = decimal.Parse(Console.ReadLine());

        // call constructor to create 2nd object
        Account myacc2 = new Account(AccHolderName, initBalance);

        // print the new acc name
        Console.WriteLine("the name of the second account is: " + myacc2.Name);

        Console.WriteLine("The initial Balance of the second account is: " + myacc2.Balance);

        Console.Write("Please enter an amount to deposit to the first acc: ");
        decimal amtToDep = decimal.Parse(Console.ReadLine());

        myAcc1.Deposit(amtToDep);

        Console.WriteLine($"the balance of the first account has been updated to {myAcc1.Balance:c}");

        //prompt the user for a value that they would like to withdraw from the second account
        Console.Write("How much money would you like to withdraw from second account:");
        decimal amtToWithdraw = decimal.Parse(Console.ReadLine());

        // call to withdraw method on the second account
        myacc2.Withdraw(amtToWithdraw);

        Console.WriteLine($"The balance in the second account after withdraw is: {myacc2.Balance:c}");

    }

}
