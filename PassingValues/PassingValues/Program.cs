using System;

//this covers pass by value, and pass by reference
public class PassingValues
{
 static void Main(string[] args)
 {
        int x = 55;
        Console.WriteLine($"Initial value of x {x}");
        Change(ref x);// pass by value (without the ref here and in the next method), a copy of the value is being passed to the method. if the method changes the value, the original value does not change
        Console.WriteLine($"new value of x {x}"); // this outputs 55 again because of what the var is in this method

        //when objects are passed (non simple data types), a copy of the reference to the object is passed. this means that if the method chages the obj, it actually changes the obj itself, not a copy.
 }

 static void Change(ref int x) //IF YOU USE REF IN THE CALL AND ARGUMENTS SECTION IT ACTUALLY CHANGES THE VAR ACROSS THE BOARD
 {
   x = x * 100;
        Console.WriteLine($"changed value is {x}"); // the change can be seen here

 }
}


