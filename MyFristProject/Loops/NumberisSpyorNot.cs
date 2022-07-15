using System;
using System.Collections.Generic;
using System.Text;

namespace MyFristProject.Loops
{
    class NumberisSpyorNot
    {
        // Check number between spy or not using ( While Loop_)
        static void Main(string[] args)
        {


            Console.WriteLine("enter number ");
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            int digit = 0;
            int product = 1;
            while (num > 0)
            {
                digit = num % 10;

                // getting the sum
                // of digits
                sum += digit;

                // getting the product
                // of digits
                product *= digit;
                num = num / 10;
            }
            Console.WriteLine("Sum ="+sum);
            Console.WriteLine("Product ="+product);
            Console.WriteLine("---------------");
            if (sum==product)
               
                Console.WriteLine("spy number= "+ sum);
            else
                Console.WriteLine("not spy number because sum and product is not same " + sum +  "and"  + product);
            

           
            
        }        

           


    }
}
