using System;
using System.Collections.Generic;
using System.Text;

namespace MyFristProject.ConditinalDemos
{
    class OddEvenNumber
    {
        // check number is odd or even using if else condition
        static void Main(string[] args)
        {
            int num1 = 2;
            Console.WriteLine("\n\n");
            Console.WriteLine("check whether number is even or odd:\n");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("\n\n");
            Console.WriteLine("Enter  number :");
            num1 = Convert.ToInt32(Console.ReadLine());
            
            if (num1 % 2==0)
            {
                Console.WriteLine("{0} is an even number.\n", num1);

            }
            else
            {
                Console.WriteLine("{0} is an odd number.\n", num1);
            }
            
        }
    }
}
