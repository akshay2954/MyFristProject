using System;
using System.Collections.Generic;
using System.Text;

namespace MyFristProject.ConditinalDemos
{
    class Larg3Numberwithoutusinglogicaloperator
    {
        //way to find larg amoung of three number using ("without using logical operator")
       // (Using Nested if else Condition)
        static void Main(string[] args)
        {
            int n1, n2, n3, large;
            Console.WriteLine("enter number 1");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter number 2");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine(" enter number 3 ");
            n3 = int.Parse(Console.ReadLine());


            if (n1 > n2)
            {
                if (n1 > n3)
                {
                    Console.Write("Number one is the largest!\n");
                }
                else
                {
                    Console.Write("Number three is the largest!\n");
                }
            }
            else if (n2 > n3)
                Console.Write("Number two is the largest!\n");
            else
                Console.Write("Number three is the largest!\n");


            Console.WriteLine("Press Enter Exit to any key");
            Console.ReadLine();







        }
    }
}

