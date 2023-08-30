using System;

public class TestingOperations
{
    public static void Main()
    {
        // all math operations +,-,*,/ (divison),% division that displays remainder 
        int num1;
        num1 = int.Parse(Console.ReadLine());
        int remainder = num1 % 2; 
        // shows 1 or 0, if its odd or even since divided by 2, add () next to var to "cast" or overrite the type(int,dec,float,etc) of the var
        // useful if decimals are involved in the result but not the initial varible or vise versa
        if (remainder > 0)
        {
            Console.WriteLine("its odd bruh");
        }
        if (remainder == 0)
        {
            Console.WriteLine("its even bruh");
        }





    }
}
