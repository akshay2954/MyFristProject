using System;
using System.Collections.Generic;
using System.Text;

namespace MyFristProject.Loops
{
    // Check number is disarium or not  ( While Loop_inner for loop )
    class DisariumNumberOrNot
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number ");
            int num = int.Parse(Console.ReadLine());
            int temp = num;
            int count = 0;

            while(num>0)
            {
                count++;
                num = num / 10;
            }
            Console.WriteLine(count);
            num = temp;
            int sum = 0;
            while(num>0)
            {
               int r = num %10;
                int power = 1;
                for(int i=1;i<=count;i++)
                {
                    power = power * r;
                }
                sum = sum + power;
                count--;
                num = num / 10;
            }
            Console.WriteLine("sum "+sum);
            num = temp;
            if(num==sum)
            {
                Console.WriteLine("Number is Disarium");
                 
            }
            else
            {
                Console.WriteLine("number is Not Disarium");
            }
        }
    }
}
