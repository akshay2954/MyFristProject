using System;
using System.Collections.Generic;
using System.Text;

namespace MyFristProject.ConditinalDemos
{
    class NewLarge3NumberusingifElse
    {
        // large 3 number using ( Nested if Else )
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Numbr 1");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Numbr 2");
            int num2 = int.Parse(Console.ReadLine()); 
             Console.WriteLine("Enter Numbr 3");
            int num3 = int.Parse(Console.ReadLine());
            if(num1>num2)
            {
                if(num1>num3)
                {
                    Console.WriteLine("Number 1 is Large= "+num1);
                }
                else
                {
                    Console.WriteLine("Number 3 is Large= "+num3);
                }
            }else if ( num2>num3)
            {
         
                    Console.WriteLine("Number 2 is Large= "+num2);
            
            }
            else
            {
                Console.WriteLine("Number 3 is large="+num3);
            }
      
            
    




        }

    }
}
