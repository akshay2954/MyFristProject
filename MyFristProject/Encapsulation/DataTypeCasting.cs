using System;
using System.Collections.Generic;
using System.Text;

namespace MyFristProject.Encapsulation
{
    class DataTypeCasting
    {
        static void Main(string[] args)
        {
            int  x = 5;             // Implicit data type casting 
            float f = x;            // lower to higher.
            Console.WriteLine(f);

            Console.WriteLine("------------------");


            float a = 50.5f;        // Explicit data type casting 
            int b = (int)a;         // data loss problehm 
            Console.WriteLine(b);   // higher to lower 


        }
    }
}
