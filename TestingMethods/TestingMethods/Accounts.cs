using System;

public class Account
{
    //if no constructor is created a default one will be created suppling null and 0



    //constructor
    public Account(String initName, decimal InitBalance)// string email) //these are called parameters
    {
        Name = initName;
        balance = InitBalance;
       // Email = email;

    }

    //attributes (instance varibles)
    //private string name; NO LONGER NEEDED WITH LINE 22

    private decimal balance;

    //auto-implemented property for the name instance var
    public string Name { get; set; }

    // auto implement property for email
    public string Email { get; set; }

    // property for the name instance varible

    //public string Name SAME AS LINE 22
    //{
    //    set { name = value; } // assign incoming val for name
    //    get { return name; } //retrieving the value of the name instance var
    //}

    //behaviors (methods)
    public void SetName(string custName) //custName is a parameter
    {
        Name = custName;//assigns customer name into name instance varible

    }
    public string GetName()//retrives name
    {
        return Name;// returns the value of the name instance varible
    }


    // property to work with the balance instance var
    public decimal Balance // no more GET statements
    {
        set
        {
            if (value >= 0)
            {
                balance = value;
            }
            else
            {
                Console.WriteLine($"Cannot withdraw more than current balance. The current balance is {balance}... the attempted withdraw amount is {value}");
            }
        }
        get
        {
            return balance;
        }

        //public void SetBalance(decimal userAmt)  NO LONGER NEEDED WITH ABOVE SECTION
        //{
        //    if (userAmt >= 0)
        //    {
        //        balance = userAmt;
        //    }

        //}
        //public decimal GetBalance()
        //{
        //    return balance;//passes the current balance to the calling side
        //}

    }

    public void Deposit(decimal amtToDeposit)
    {
        Balance = Balance + amtToDeposit;
    }
    public void Withdraw(decimal amtToWithdraw)
    {
        Balance = Balance - amtToWithdraw;
    }
}