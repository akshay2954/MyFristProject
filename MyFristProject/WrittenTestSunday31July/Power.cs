using System;
using System.Collections.Generic;
using System.Text;

namespace MyFristProject.WrittenTestSunday31July
{
    class Power
    {
        // 2. WAP to calculate x y where x is base and y is index without using readymade function.
        static int show (int a, int b, int c)
        {
            int result = 1;
            while(b>0)
            {
                if ((b & 1) != 0)
                    result = result * a;

                b = b >> 1;
                a = a * a;
            }
            return result % c;
        }


        static void Main(string[] args)
        {
            int a = 2;
            int b = 5;
            int c = 13;
            Console.WriteLine("Poewr is "+show(a,b,c));
        }
    }
}
