using System;
using System.Collections.Generic;
using System.Text;

namespace MyFristProject.Loops
{
    class CalculatePower
    {
        //calculate the power of base of exponent ( For loop)
        static void Main(string[] args)
        { 
            // Console.WriteLine(Math.Pow(4,3));
            Console.WriteLine("Enter base");
            int base_number = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter exponent");
            int expo = Convert.ToInt32(Console.ReadLine());
            int power = 1;

            for(int i=1;i<=expo;i++)
            {
                power = power * base_number;
            }
            Console.WriteLine("--------");
            Console.WriteLine("Total Power"+power);

        }
    }
}
