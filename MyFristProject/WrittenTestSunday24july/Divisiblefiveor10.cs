using System;
using System.Collections.Generic;
using System.Text;

namespace MyFristProject.WrittenTestSunday24july
{
    class Divisiblefiveor10
    {
        // 1.Write a program to print all numbers between 1 and 100 except the numbers which are divisible by 5or 10
        static void Main(string[] args)
        {
            for (int i=1;i<=100;i++)
            {
                if (i%5!=0 && i%10!= 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
