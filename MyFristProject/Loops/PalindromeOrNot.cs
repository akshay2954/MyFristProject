using System;
using System.Collections.Generic;
using System.Text;

namespace MyFristProject.Loops
{
    class PalindromeOrNot
    {
       // Check Number is Pailndrome Using ( While loop inner if else)
        static void Main(string[] args)
        {
            Console.WriteLine("enter number ");
            int num = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int r, pal;
            pal=num; 
            while (num > 0)
            {
                r = num % 10;
                sum = (sum * 10) + r;
                num = num / 10;
            }
            if(pal==sum)
            
                Console.WriteLine("number is Palindrome :");
            else
                Console.WriteLine("Number is Not Palindrome");
            
        }

    }
}
