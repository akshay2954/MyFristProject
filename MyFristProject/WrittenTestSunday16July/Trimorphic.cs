using System;
using System.Collections.Generic;
using System.Text;

namespace MyFristProject.WrittenTestSunday16July
{
    class Trimorphic
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Enter number ");
            int num = int.Parse(Console.ReadLine());
            int squre;
            int a = 1;
            squre = num * num * num;
            while(num>0)
            {
                if (num%10!=squre%10)
                {
                    a = 0;

                }
                num = num / 10;
                squre = squre / 10;

            }
            {
                if(a==1)
                {
                    Console.WriteLine(" Trimorphic  ");
                }
                else
                {
                    Console.WriteLine("Not trimorphic");
                }
            }


        }
    }
}
