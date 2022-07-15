using System;
using System.Collections.Generic;
using System.Text;

namespace MyFristProject.ConditinalDemos
{
    class DivisibleFive
    { 
        // check the program is positive negative or zero using if else condition
        static void Main(string[] args)
        {
            
            Console.WriteLine(" \n enter number :");
            int  num1 = Convert.ToInt32(Console.ReadLine());
            if( num1 % 5== 0)
            {
                Console.WriteLine("The number is Dividible by 5 :");
            }
            else
            {
                Console.WriteLine(" The number is Not Divisible by 5:");
            }
        }
    }
}
