using System;
using System.Collections.Generic;
using System.Text;

namespace MyFristProject.WrittenTestSunday16July
{
    class NumberSeriesSum
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int fact = 0;
            Console.WriteLine("Enter last Digit ");
            int num = int.Parse(Console.ReadLine());
            for(int i= 1; i<=num; i++)
            {
                fact = 1;
                if(i!=num)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    Console.WriteLine(i);
                }
                for(int j=1; j<=i; j++)
                {
                    fact = fact * j;
                    sum = sum + fact;

                }
                Console.WriteLine("sum="+sum);
            }
            


        }
    }
}
