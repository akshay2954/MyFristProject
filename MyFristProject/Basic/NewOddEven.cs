using System;
using System.Collections.Generic;
using System.Text;

namespace MyFristProject.Basic
{
    class NewOddEven
    {
        static void Main(string[] args)
        {
            int rem1;
            Console.WriteLine("Input an Integer");
            int num1 = int.Parse(Console.ReadLine());
            rem1 = num1 % 2;
            if(rem1 ==0)
            
                Console.WriteLine("Even Numbrer"+num1 );
                else
                 Console.WriteLine("Odd Number" +num1 );
            
        }

    }
}
