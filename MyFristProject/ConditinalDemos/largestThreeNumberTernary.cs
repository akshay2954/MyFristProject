using System;
using System.Collections.Generic;
using System.Text;

namespace MyFristProject.ConditinalDemos
{
    class largestThreeNumberTernary
    {
        //find out largest 3 number using ( "Logical And Ternary Operator")
        static void Main(string[] args)
        {

            // Syntax condition ? statement 1 : statement 2
            int result;
            Console.WriteLine("enter number 1");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter number 2");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter number 3");
            int n3 = int.Parse(Console.ReadLine());
            
            result = n1> n2 && n1 > n3 ? n1: n2 > n1 && n2 > n3? n2 :n3;
            //Console.WriteLine("number 1 Lage ="+ n1);
            //Console.WriteLine("number 2 Lage =" + n2);
          //  Console.WriteLine("number 3 Lage =" + n3);
            Console.WriteLine(" largest among {0} {1} {2} is {3}", n1,n2,n3,result);
            Console.WriteLine(" press any key to exit");
            Console.ReadKey();

             
        }
    }
}
