using System;
using System.Collections.Generic;
using System.Text;

namespace MyFristProject.New_OPPS
{
    class HappyNumber
    {
        // Check number is Happy or not 
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number ");
            int num = Convert.ToInt32(Console.ReadLine());
            bool temp = true;
            while(num>0)
            {
                int r = num % 10;
                if (r%2==0)
                {
                   temp= false;
                    break;

                }
                num = num / 10;
            }
            if (temp==true)
            {
                Console.WriteLine("Happy  ");

            }
            else
            {
                Console.WriteLine("Not Happy ");
            }



        }
    }
}
