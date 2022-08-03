using System;
using System.Collections.Generic;
using System.Text;

namespace MyFristProject.WrittenTestSunday31July
{
    class MobileNumber
    {
       // 1 WAP to accept mobile number and count frequency of digit
        int Digit(long n, int a)
        {
            int b = 0;
            while(n>0)
            {
                if (n % 10 == a);
                b++;

                n = n/ 10;
            }
            return b;
        }
        static void Main(string[] args)
        {
            MobileNumber M = new MobileNumber();

            Console.WriteLine("Enter Mobile number");
            long n = long.Parse(Console.ReadLine());

            Console.WriteLine("Find Frequency of ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine(M.Digit(n,a));
        }
    }
}
