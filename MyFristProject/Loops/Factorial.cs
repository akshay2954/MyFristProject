using System;
using System.Collections.Generic;
using System.Text;

namespace MyFristProject.Loops
{
    class Factorial
    {
        // Factorial of given user input from user number  ( For loop)
        static void Main(string[] args)
        {

            Console.WriteLine("Enter Number=");
            int num = int.Parse(Console.ReadLine());
            int fact = 1;
            for(int i=1;i<=num;i++)
            {
                fact = fact * i;
            }
            Console.WriteLine("Total Number of Factorial = "+fact);

        }
        
        
    }
}
