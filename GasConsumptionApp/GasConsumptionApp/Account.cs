//Mist 352 Assignment 2 "Gas Consumption App"
//William Slocum

using System;

public class Account
{    
    public string CustName { get; set; } //instance var auto-implemented properties for name,account, and balance
    public int AcctNum { get; set; }
    public string CusType { get; set; }

    private decimal Bal;  //varibles for bill calculation
    decimal mCF;
    decimal gasRate;
    decimal usageCharge;
    decimal municipalTax;
    decimal exciseTax;

    public Account(string cusName,int accNum, string gasType) // constructor for the variable auto properties
    {
        CustName = cusName;
        AcctNum = accNum;
        CusType = gasType;
    }

    
    public void ComBill()   // bill calculation methods split into 2 groups, one for commercial and one for residential
    {
        Console.Write("Please enter the MCF used during the past month: ");
        mCF = decimal.Parse(Console.ReadLine()); //allows user to input mcf used 

        Console.WriteLine(""); //some space
        Console.WriteLine("");

        gasRate = 11.99M;

        usageCharge = mCF * gasRate; // calculations for usage,taxes, and balance

        municipalTax = usageCharge * .02M;

        exciseTax = usageCharge * .05M;

        Bal = usageCharge + municipalTax + exciseTax;
        
    }

    public void ResBill() //same format as the commercial
    {
        Console.Write("Please enter the MCF used during the past month: ");
        mCF = decimal.Parse(Console.ReadLine());

        Console.WriteLine("");
        Console.WriteLine("");

        gasRate = 8.99M;

        usageCharge = mCF * gasRate;

        municipalTax = usageCharge * .02M;       

        exciseTax = usageCharge * .05M;      

        Bal = usageCharge + municipalTax + exciseTax;
        
    }

    public void BillUI() //method displays the bill for the user according to required specifications
    {
        Console.WriteLine("Gas Consumption Bill");
        Console.WriteLine($"Account Number:{AcctNum} ");
        Console.WriteLine($"Customer Name: {CustName}");
        Console.WriteLine("");
        Console.WriteLine("-------------------------------------------------------------");
        Console.WriteLine("");
        Console.WriteLine($"Service Rate: ${gasRate:F} ");
        Console.WriteLine($"MCF Used: ${mCF} ");
        Console.WriteLine($"Usage Charge: ${usageCharge:F} ");
        Console.WriteLine($"Municipal Charge: ${municipalTax:F}");
        Console.WriteLine($"Excise Tax: ${exciseTax:F}");
        Console.WriteLine("-------------------------------------------------------------");
        Console.WriteLine($"Balance: ${Bal:F}");  //P.S. i finally figured out how to format numbers for currency without using the math.round function
    }
}