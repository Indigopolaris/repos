using System;

public class PayrollTest
{
    public static void Main()
    {

        Console.WriteLine("This application calculates the salary of an employee based on their current status.");
        Console.WriteLine("------------------------------------------------------------------------------------");

        Console.Write("Enter the employee name: ");
        string employeeName = Console.ReadLine();

        Console.Write(" Enter the employee status. (H for hourly and S for salary): ");
        string status = Console.ReadLine();
        Console.WriteLine("------------------------------------------------------------------------------------");

        if (status == "H")
        {
            Console.Write("Please enter the hours worked: ");
            decimal initHours = decimal.Parse(Console.ReadLine());
            Console.Write("Enter the Hourly rate: ") ;
            decimal initRate = decimal.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("---------------------------------------------------------------------------------");

            //PayRollH.WritePayslipEmpH(); 
        }
        else
        {
            decimal initHours = 0;
            decimal InitRate = 0;

           // PayRollS.WritePayslipEmpS();
        }


    }
}

