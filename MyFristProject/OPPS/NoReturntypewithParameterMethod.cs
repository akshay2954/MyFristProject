using System;
using System.Collections.Generic;
using System.Text;

namespace MyFristProject.OPPS
{
    class NoReturntypewithParameterMethod
    {
        // No Return with parameter method. 
        public void Addition(int a, float b) // Addition method 
        {
            float ans = a + b;
            Console.WriteLine("Answer = "+ans); 
        }
        static void Main(string[] args) // Main method 

        {
            NoReturntypewithParameterMethod e = new NoReturntypewithParameterMethod();// Object Creation
            e.Addition(10,5.5f); // Calling with parameter.   


        }
    }
}
