using System;
using System.Collections.Generic;
using System.Text;

namespace MyFristProject.WrittenTestSunday24july
{
    class Redblue
    {
        // 6. Write a program to print number from 1 to 100 such that when a number is factor of 3 and 5 both print  “RedBlue”  and if given number is factor of only 3 the print “red” and if given number is factor of only 5 then “blue” otherwise the number itself
        static void Main(string[] args)
        {
            for(int i=1;i<=100;i++)
            {
                if(i%3==0 && i%5==0)
                {
                    Console.WriteLine("ReadBlue");
                }
                else if (i%3==0)
                {
                    Console.WriteLine("Red");
                }
                else if (i%5==0)
                {
                    Console.WriteLine("Bulue ");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }

        }
    }
}
