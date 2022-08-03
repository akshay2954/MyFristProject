using System;
using System.Collections.Generic;
using System.Text;

namespace MyFristProject.New_OPPS
{
    class IMEINumber
    {
        // Check Number is IMEI or NOt 
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number ");
            long  num = long.Parse(Console.ReadLine());
            long sum = 0;
            long M = num;
            while(num> 0)
            {
                long r = num % 10;
                sum = sum + r;
                num = num / 10;
            }
            num = M;
            if( sum % 10==0)
            {
                Console.Write(" IMEI Numbrer ");
            }
            else
            {
                Console.Write("Not IMEI Number ");
            }

        }

    }
}
