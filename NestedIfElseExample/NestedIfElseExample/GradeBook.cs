using System;

public class GradeBook
{

    //attribute, auto imp prop
    public string Cname { get; set; }
    public int Credits { get; set; }

    //constructor
    public GradeBook(int numOfCredits, string courseName)
    {
        Cname = courseName;
        Credits = numOfCredits;
    }

    //behaviors
    public void AssessGrade()
    {
        Console.Write("enter grade: ");
        int grade = int.Parse(Console.ReadLine()); // grade is 
        // parse converts user input into int number for console

        //nested if else
        // if you have upper and lower bounds they dont have to be in order
        if (grade >= 90 && grade <= 150)
        {
            Console.WriteLine("you got A");
        }
        else if (grade >= 80 && grade <= 89)
        {
            Console.WriteLine("You got B");
        }
        else if (grade >= 70 && grade <= 79)
        {
            Console.WriteLine("you got C");
        }
        else if (grade >= 60 && grade <= 69)
        {
            Console.WriteLine("you got D");
        }
        else
        {
            Console.WriteLine("You failed");
        }
    }
}
