using System;
using System.Collections.Generic;
using System.Text;

namespace MyFristProject.Basic
{
    class NewSubtraction
    {
        static void Main(string[] args)
        {
            int ans;
            Console.WriteLine("Enter number1 ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Number2");
            int num2 = int.Parse(Console.ReadLine());
            ans = num1 - num2;
            Console.WriteLine("Subtraction= "+ans);
        }
    }
}
