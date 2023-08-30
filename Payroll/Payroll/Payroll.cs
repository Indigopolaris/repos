//William Slocum Assignment 2 Mist 352
using System;

public class Payroll
{
    //constructor
    public Payroll(string empName,string empType,decimal empHours, decimal empRate)
    {
        FullName = empName;
        Status = empType;
        HoursWorked = empHours;
        HourlyPay = empRate;
    }
   // public Payroll(string ,string )

    
    private decimal HPay;
    private decimal Salary;
    private decimal Hoursworked;
    private decimal Hourlypay;


   public string FullName { get; set; } //auto implemented properties
   public string Status { get; set; }
 
   public decimal HoursWorked { get; set; }
   
   public decimal HourlyPay { get; set; }

   
   public void HEmployee()
    {
      
    }
   public void SEmployee()
    {

    }
}