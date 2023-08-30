using System;

public class GradeBook
{
    //prop tab tab
    public int Credits { get; set; }

    public string Cname { get; set; }

    public GradeBook(int credits, string cname)
    {
        Credits = credits;
        Cname = cname;
    }

    public double AssessGrades()
    {
        int total = 0;
        int count;
        for( count=1; count <= 10; count += 1)
        {
            Console.WriteLine("enter grade: ");
            int grade = Convert.ToInt32(Console.ReadLine());

            total += grade;


        }
        double avg =(double) total / 10;

        Console.WriteLine("the avg of the 10 grades is" + avg);
        Console.WriteLine($"the avg of the 10 grades is {avg}");
        // ALL DO THE SAME THING
        Console.WriteLine("The avg of the {0} is {1:f}", 10, avg);

        return avg;
    }

}