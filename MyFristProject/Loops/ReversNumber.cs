using System;
using System.Collections.Generic;
using System.Text;

namespace MyFristProject.Loops
{
    class ReversNumber
    {
        //  Write a program to user get from input resvese number using ( While Loop_)
        static void Main(string[] args)
        {
            Console.WriteLine("enter number ");
            int num = Convert.ToInt32(Console.ReadLine());
            int reverse = 0;
            while(num>0)
            {
                int r = num % 10;
                reverse = reverse * 10 + r;
                num = num / 10;
            }
            Console.WriteLine(reverse);

        }
    }
}
