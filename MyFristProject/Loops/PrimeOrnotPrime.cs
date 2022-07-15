using System;
using System.Collections.Generic;
using System.Text;

namespace MyFristProject.Loops
{
    class PrimeOrnotPrime
    {
        // write a program to check number is prime or not using ( For loop with if else)
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number ");
            int num = Convert.ToInt32(Console.ReadLine());
            bool isprime = true;
            for (int i = 2; i >= num; i++) 
            {
                if (num % i == 0)
                {
                    isprime = false;
                }
            }
                if(isprime==true)
                {
                Console.WriteLine(" Is A Prime Number");
                }
            else
            {
                Console.WriteLine("Not A Prime Number");
            }
        }    
 
    }
}
