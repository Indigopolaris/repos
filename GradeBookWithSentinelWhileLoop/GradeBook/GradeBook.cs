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

  //behaviors(methods)
  public void AssessGrade()
    {
        int numOfGrades = 0;// tracks num of grades entered
        int total = 0;
        //sentinel loop (sentinel is a guarding value to stop loop, like a stop)
        // ask for 1st input
        Console.WriteLine("enter a grade or -1 to exit:  ");
        int grade = int.Parse(Console.ReadLine());

        while (grade != -1)
        {
            numOfGrades++;

            total = total + grade;// total += grade

            //ask for next input
            Console.WriteLine(" enter next grade or -1: ");
            grade = int.Parse(Console.ReadLine());
        }

        double avg = (double)total / numOfGrades;
        Console.WriteLine($"The sum of the {numOfGrades} grades are {total}\n the avg of the grades is {avg}");
    }
}
