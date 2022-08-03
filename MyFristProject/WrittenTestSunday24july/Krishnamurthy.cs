using System;
using System.Collections.Generic;
using System.Text;

namespace MyFristProject.WrittenTestSunday24july
{
    class Krishnamurthy
    {
        // 8.	Write a code to check given number is Krishnamurthy number or not
      static void Main(string[] args)
      {
            int A;
            int sum;
            int digit;
            int fact;
            Console.WriteLine("Enter Number ");
            int num = int.Parse(Console.ReadLine());
            A = num;
            sum = 0;
            while(A !=0)
            {
                digit = A % 10;
                fact= 1;
                for (int i=1; i <= digit; i++)
                {
                    fact = fact * i;

                }
                sum = sum + fact;
                A = A / 10;
                if(sum==num)
                {
                    Console.WriteLine(" Krishnamurty ");
                }
                else
                {
                    Console.WriteLine(  "Not Krishnamurty");
                }

            }
            


      }
    }
}
