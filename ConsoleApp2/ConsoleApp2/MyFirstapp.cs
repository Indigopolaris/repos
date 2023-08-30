using System;
public class MyFirstapp
{    
    public static void Main()
    { 
        Console.WriteLine("get mad bitches \nyo");

        int[] array = { 1, 1, 1, 1, 1, 1, 1, 1 };
        int sum = 0;
        int avg = 0;

        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i]; 
            avg = sum / array.Length;
        }
        Console.WriteLine($"{sum}, {avg}");
    
    // escape sequences: \\, \t(tab), \n(down line), \", \r (useless)
    }




}