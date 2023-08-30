using System;

public class GradeBookTest
{

    public static void Main()
    {

        //one stmt to create object of the GradeBook class
        GradeBook mygb = new GradeBook(3, "mist 352");
        // 3 is numofcredits from constructor and mist 352 is a string coursename for the name of the class
        //relates to constructor var on gradebook side
        //mygb is a handle to the gradebook object

        mygb.AssessGrade();
    }

}