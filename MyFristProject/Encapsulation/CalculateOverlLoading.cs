using System;
using System.Collections.Generic;
using System.Text;

namespace MyFristProject.Encapsulation
{
    class CalculateOverlLoading
    {
        // Overload Calculate Method 

        void calculate()                                // call 1 method 
        {
            Console.WriteLine("Calculate ");
        }
        int calculate(int a, int b)                     // call 2 method 
        {
            return a - b;
        }

        float calculate (float z, float y)              // call 3 method 
        {
            return z + y;
        }

        double calculate (double s,double g)            // call 4 method 
        {
            return  s * g;
        }

        double calculate(int d, double f)              // call 5 method 
        {
            return d / f;
        } 
        static void Main(string[] args)
        {
            CalculateOverlLoading c = new CalculateOverlLoading();

            c.calculate();                             // call 1 method

            int ans = c.calculate(100,50);             // Call 2 method 
            Console.WriteLine("substraction= " + ans);

            float f = c.calculate(5.5f,10.5f);         // call 3 method 
            Console.WriteLine("Addition= "+ f );

            double d = c.calculate(5.5, 5.5);          // call 4 method 
            Console.WriteLine("Multiplication=" +d);      

            double d2 =  c.calculate(50,2.5 );         // call 5 method 
            Console.WriteLine("dividion= "+ d2);

        }
    }
}
