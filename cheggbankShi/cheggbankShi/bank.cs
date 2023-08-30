class Bank
{
    // array of Account objects
    private Account[] accountsArray = new Account[10];

    // method to add an Account with given accountID, accountName, and 2D array of deposits and returns true if Account is added
    // else return false
    public bool AddAccount(string accountID, string accountName, int[][] deposits)
    {
        // loop over the array to find the first non-null element
        for (int i = 0; i < accountsArray.Length; i++)
        {
            if (accountsArray[i] == null) // non-null element found
            {
                // create an object of Account class and set to ith element and return true
                accountsArray[i] = new Account(accountID, accountName, deposits);
                return true;
            }
        }

        return false; // Account not added
    }

    // method to call UpdateAccount for all Account objects in the array
    public void ApplyDeposits()
    {
        // loop over the array
        for (int i = 0; i < accountsArray.Length; i++)
        {
            if (accountsArray[i] != null) // ith element is not null, call UpdateAccount
                accountsArray[i].UpdateAccount();
            else // ith element is null, exit the loop
                break;
        }
    }

    // method to return string representation of the Bank
    public override string ToString()
    {
        string bankStr = "";
        // loop over the array of Account objects, appending the ToString version of each Account to bankStr
        for (int i = 0; i < accountsArray.Length; i++)
        {
            if (accountsArray[i] != null) // ith element is not null
                bankStr += accountsArray[i].ToString() + "\n\n";
            else // ith element is null, exit the loop
                break;
        }

        if (bankStr.Length > 0)
            return bankStr;
        else
            return "No Account Found";

    }

}

class BankTest
{

    public static void Main()
    {

        // create a new object of Bank class
        Bank bank = new Bank();
        // add accounts to bank
        bank.AddAccount("2605", "John doe", new int[][] { new int[] { 90, 50, 70 }, new int[] { 40, 50 } });
        bank.AddAccount("2616", "Shaun Marsh", new int[][] { new int[] { 90, 50 }, new int[] { 50 } });
        bank.AddAccount("2601", "Mike Sullivan", new int[][] { new int[] { 40, 50, 70 }, new int[] { 40, 50, 20, 10 } });
        bank.AddAccount("2611", "Sean Smith", new int[][] { new int[] { 50, 70 }, new int[] { 40, 50, 10 } });
        bank.AddAccount("2212", "John Smith", new int[][] { new int[] { 90, 50, 70 }, new int[] { 40, 50 } });
        bank.AddAccount("1223", "Kelly Larson", new int[][] { new int[] { 90, 50, 70 }, new int[] { 40, 50 }, new int[] { 50, 66 } });
        bank.AddAccount("1101", "Nick Fuller", new int[][] { new int[] { 90, 70 }, new int[] { 40, 50 } });
        bank.AddAccount("1511", "Jake Cooper", new int[][] { new int[] { 90, 20 }, new int[] { 50 } });
        bank.AddAccount("1415", "Derek Kent", new int[][] { new int[] { 90, 50, 70 }, new int[] { 40, 50 } });
        bank.AddAccount("8711", "Jane Doe", new int[][] { new int[] { 30, 20, 70 }, new int[] { 40, 50 } });

        // apply deposits
        bank.ApplyDeposits();

        // display the ToString version of bank
        Console.WriteLine(bank);
    }
}