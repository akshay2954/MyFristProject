using System;
using System.Collections.Generic;
using System.Text;

namespace MyFristProject.Loops
{
    class ArmstrongNumber
    {
        // Check Number is Armstrong or Not ( While loop_if else )
        static void Main(string[] args)
        {
            int strong;
            int sum = 0;

            Console.WriteLine("enter Number") ;
            int num = int.Parse(Console.ReadLine());
            strong = num;
            while(num>0)
            {
                int r = num % 10;
                sum = sum + (r * r * r);
                num = num / 10;
            }
            if(strong==sum)
                Console.WriteLine("Armstrong Number "+ sum);
            else
                Console.WriteLine("Not Armstrong Number "+ sum);
                




        }
    }
}
