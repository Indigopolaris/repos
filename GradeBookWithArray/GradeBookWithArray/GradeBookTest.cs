using System;

public class GradeBookTest
{

    public static void Main()
    {

        string cn = "MIST 352";

        // 15 is num of elements in array (it is the length)
        //int[] grades = new int[15];// array creation expression

        // createing an anrray using an array initializer list
        int[] gradesInArr = { 99, 98, 97, 77, 55, 66, 99, 100, 12, 88, 99, 100 };

        GradeBook mygb = new GradeBook(cn, gradesInArr);
        mygb.AssessGrades();
    }
}