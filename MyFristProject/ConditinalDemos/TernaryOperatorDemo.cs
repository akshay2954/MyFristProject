using System;
using System.Collections.Generic;
using System.Text;

namespace MyFristProject.ConditinalDemos
{
    class TernaryOperatorDemo
    {
        // check the number is greater  using ( if else And Ternary operator )
        static void Main(string[] args)
        {
            Console.WriteLine("Enter frist number ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number");

            int num2 = int.Parse(Console.ReadLine());

            if( num1<num2)
            {
                Console.WriteLine("num1 ");
            }
            else 
            {
                Console.WriteLine("num2 ");
            }

            string ans = num1 > num2 ? "num1 is greater" : "num2 is greater";
            Console.WriteLine("ans= " + ans);

        }
    }
}
