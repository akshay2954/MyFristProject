using System;
using System.Collections.Generic;
using System.Text;

namespace MyFristProject.ConditinalDemos
{
    class OddEvenUsingTernaryOperator
    {
        // WAP To Find out number is odd or even ( "only using Ternary Operator" )
        static void Main(string[] args)
        {
            int n1 = 2;
            Console.WriteLine("enter number :");
            n1 = int.Parse(Console.ReadLine());

            string number=  (n1 % 2 == 0)  ? "This is Even number" : " This is odd number";
            Console.WriteLine("Ans = "+ number);
            Console.ReadKey();

            
              
        }
    }
}
