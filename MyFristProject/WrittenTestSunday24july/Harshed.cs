using System;
using System.Collections.Generic;
using System.Text;

namespace MyFristProject.WrittenTestSunday24july
{
    class Harshed
    {
        //5.To find whether the given number is a Harshad number or not, 
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Number ");
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            int rem = 0;
            int n = num;
            while(num>0)
            {
                rem = num / 10;
                sum = sum + rem;
                num = num / 10;

            }
            if (n%sum==0)
            {
                Console.WriteLine("Harshed Numbr ");
            }
            else
            {
                Console.WriteLine("Not Harshed ");
            }
        }

    }
}
