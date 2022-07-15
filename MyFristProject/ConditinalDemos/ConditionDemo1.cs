using System;
using System.Collections.Generic;
using System.Text;

namespace MyFristProject.ConditinalDemos
{
    class ConditionDemo1
    { 
        // Check Greater number between 2 number 
        // Using Only (Else if)
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Frist number ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Ssecond Number");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine("Number 1 is Greater= " + num1);
            }
            else if (num2 > num1)
            {
                Console.WriteLine("Number 2 is Greater = " + num2);
            }
            else if (num1==num2)
            {
                Console.WriteLine("No Greater No Less Number Between Same try Again....."); 
            }
            else
            {
                Console.WriteLine(" Enter Invalid");
            }
                 
              
        }
    }
}
