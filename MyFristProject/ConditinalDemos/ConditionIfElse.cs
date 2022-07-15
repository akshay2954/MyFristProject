using System;
using System.Collections.Generic;
using System.Text;

namespace MyFristProject.ConditinalDemos
{
    class ConditionIfElse
    {
        // Check Number is Positive,Negative and Zero Using ( if else Condition)
        // Without using Logical Operator
        static void Main(string[] args)
        {
            int num ;
            Console.WriteLine(" Enter A number ");
            num = Convert.ToInt32(Console.ReadLine());
            if( num > 0)
            {
                Console.WriteLine("The Number is negative");
            }
            else if ( num ==0)
            {
                Console.WriteLine("number is zero");
            }
            else  
            {
                Console.WriteLine(" The Number is Positive");
            }
        }
    }
}
