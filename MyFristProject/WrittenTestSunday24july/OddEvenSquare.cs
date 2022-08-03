using System;
using System.Collections.Generic;
using System.Text;

namespace MyFristProject.WrittenTestSunday24july
{
    class OddEvenSquare
    {
        // 3. WAP to print number from 1 to 50 if number is even then print as it is and number is odd then print its square
        static void Main(string[] args)
        { 
           
            Console.WriteLine("Enter Number ");
            int num = int.Parse(Console.ReadLine());
            string ans = num %2==0 ? "Even number " : "Odd Number ";
            Console.WriteLine("ans = " + ans);

            if(num%2==1)
            {
                Console.WriteLine("square= "+ num*num);
            }
            
        }
    }
}
