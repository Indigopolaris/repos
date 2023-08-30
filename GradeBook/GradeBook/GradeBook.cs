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
        /* counter control while loop structure
         * create the counter
         * 
         * while(condition)
         * {
         *   update of the counter
         * }
         */
        int total = 0;
        int count = 0;

        // if local var compilier will not fill with a zero
        int numOfA = 0;
        int numOfB = 0;
        int numOfC = 0;
        int numOfD = 0;
        int numOfF = 0;

        //using nested if else
        while(count < 10)
        {
            Console.WriteLine("enter student grade: ");
            int grade = int.Parse(Console.ReadLine());

            if (grade >= 90 && grade <= 150)
            {
                numOfA = numOfA + 1; // numOfA ++
            }
            else if (grade >= 80 && grade <= 89)
            {
                numOfB = numOfB + 1;
            }
            else if (grade >= 70 && grade <= 79)
            {
                numOfC = numOfC + 1;
            }
            else if (grade >= 60 && grade <= 69)
            {
                numOfD = numOfD + 1;
            }
            else
            {
                numOfF = numOfF + 1;
            }

            total = total + grade;
            //update of the counter
            count ++; //count = count + 1

        } //end of while loop
         double avg = (double)total / (count);

        // $ means you want to use string interpolation 
        // \n means to write a new line
        Console.WriteLine("the sum of grades is: " + total);
        Console.WriteLine($"The avg of grades are {avg}");

        Console.WriteLine($"num of A's: {numOfA}\nNumber of B's: {numOfB}\nNumber of C's: {numOfC}\nNumber of D's: {numOfD}\nNumber of F's: {numOfF}\n ");

       
    }
}
