using System;

public class GradeBookTest
{
    public static void Main()
    {

        Console.WriteLine("enter course name followed by number of credits: ");
        string cname = Console.ReadLine();
        int credits = int.Parse(Console.ReadLine());// int.parse= Convert.ToInt32 32 is number value length, which is an int in this case

        GradeBook mygb = new GradeBook(credits, cname);

        mygb.AssessGrades();
    }
}