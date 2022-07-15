using System;
using System.Collections.Generic;
using System.Text;

namespace MyFristProject.PenPaperTest
{
    class MaxThreeNumber
    {
        //write a program to print max of 3 number 
        static void Main(string[] args)
        {
            Console.WriteLine("enter number 1");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter number 2");
            int n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter number 3");
            int n3 = int.Parse(Console.ReadLine());
            if(n1>n2 && n1> n3)
                Console.WriteLine("Number 1 Large =" + n1);
            else if (n2 > n1 && n2 > n3)
                Console.WriteLine("Number 2 Large= " + n2);
            else
                Console.WriteLine("Number 3 Large= " + n3);



        }
    }
}
