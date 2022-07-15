using System;
using System.Collections.Generic;
using System.Text;

namespace MyFristProject.ConditinalDemos
{
    class PositiveNegativeZero
    {
        // check positive negative or zero using if else condition
        static void Main(string[] args)
        {
            Console.WriteLine(" Enter A number");
            int num = Convert.ToInt32(Console.ReadLine());
            if(num>0 )
            {
                Console.WriteLine("positive Number");
            }
            else if (num==0)
            {
                Console.WriteLine(" Number is zero");
            }
            else
            {
                Console.WriteLine(" Negative Number");
            }
        }
    }
}
