using System;
using System.Collections.Generic;
using System.Text;
                                       // Public:- public is a acccess modifiers access to everywherw
namespace MyFristProject.OPPS
{
    class Student
    {
        // Assign the value and create the object inside the main method.

        public int id;                // <--  Instance Variable 
        public  string name;          // <--  Instance Variable
        public double marks;          // <--  Instance Variable
        static void Main(string[] args) //<=   Main method
        {
            Student stud1 = new Student();  // <-- Object Creation // stud1:= New student creating the Object is Stud1.
            stud1.id = 101;           // <--  Local Variable
            stud1.name = "Akshay";    // <--  Local Variable
            stud1.marks = 92.34;      // <--  Local Variable

            Console.WriteLine(stud1.id+" "+stud1.name+" "+stud1.marks); //<-- Display Result

        }

        
       
    }
}
