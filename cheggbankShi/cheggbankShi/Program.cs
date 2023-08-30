using System;

// Account class
class Account
{
    // attributes
    private string accountID;
    private string accountName;
    private int[][] deposits;
    private double balance;

    // default constructor to initialize string variables to empty string and balance to 0 and deposits to null
    public Account()
    {
        accountID = "";
        accountName = "";
        deposits = null;
        balance = 0;
    }

    // overloaded constructor to initialize accountID, accountName and deposits array to specified values
    // and balance to 0
    public Account(string accountID, string accountName, int[][] deposits)
    {
        this.accountID = accountID;
        this.accountName = accountName;
        this.deposits = deposits;
        balance = 0;
    }

    // method to compute balance as sum of all deposits
    public void UpdateAccount()
    {
        if (deposits != null)
        {
            for (int i = 0; i < deposits.Length; i++)
            {
                for (int j = 0; j < deposits[i].Length; j++)
                    balance += deposits[i][j];
            }
        }
    }

    // method to return string representation of deposits
    public string GetDeposits()
    {
        string depositStr = "";
        if (deposits != null)
        {
            for (int i = 0; i < deposits.Length; i++)
            {
                for (int j = 0; j < deposits[i].Length; j++)
                    depositStr += deposits[i][j] + " ";
                depositStr += "| ";
            }
        }
        else
            depositStr = "None";
        return depositStr;
    }

    // method to return string representation of the Account
    public override string ToString()
    {
        return "ID: " + accountID + "\nName: " + accountName + "\nDeposits: " + GetDeposits() + "\nBalance: " + balance.ToString("0.00");
    }
}
