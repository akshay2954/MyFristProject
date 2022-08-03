using System;
using System.Collections.Generic;
using System.Text;

namespace MyFristProject.OPPS
{
    class WithReturntypeNoParameter
    {
        // With Return with No Parameter method 
        public int AreaofRectangle()
        {
            int a = 5 * 4;
            return a; // return a value store in int myarea

        }
        static void Main(string[] args)// main method
        {
            WithReturntypeNoParameter e = new WithReturntypeNoParameter(); // object creation 
            int myarea = e.AreaofRectangle();// calling method with return type 
            Console.WriteLine("Area Of Rectangle = "+ myarea);// print result . 

        }

    }
}
