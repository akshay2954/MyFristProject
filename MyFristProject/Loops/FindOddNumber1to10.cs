using System;
using System.Collections.Generic;
using System.Text;

namespace MyFristProject.Loops
{
    class FindOddNumber1to10
    {
        // Find out Odd number from 1 to 10  using (For loop)
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number 1");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number 2");
            int num2 = Convert.ToInt32(Console.ReadLine());

     
            Console.WriteLine("Odd Number between Number " + num1+" To  " +num2 );
           // Console.WriteLine(" and "+num2);
            
           
            int sum = 0;
            int n = num1;
            int n2 = num2;
            for(int i=n;i<n2;i++)
            {
                if(i%2!=0)
                {
                    sum = sum + i;
                    Console.WriteLine(i);
                
                }
                
            }
            Console.WriteLine("-----------");
            Console.WriteLine("Addition="+sum);
            
           
             
           
        }
    }
}
