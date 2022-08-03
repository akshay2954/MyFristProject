using System;
using System.Collections.Generic;
using System.Text;

namespace MyFristProject.WrittenTestSunday16July
{
    class SpyorNot
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number ");
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            int digit = 0;
            int product = 1;
            while(num>0)
            {
                digit = num % 10;
                sum += digit;
                product *= digit;
                num = num / 10;
            }
            Console.WriteLine("Sum="+sum);
            Console.WriteLine("Product="+ product);
            if(sum==product)       
            {
                Console.WriteLine("Number is Spy "+ num);
            }
            else
            {
                Console.WriteLine("Number is not spy "+ num + " and"+ product);
            }
            Console.ReadKey();


        }

    }
}
