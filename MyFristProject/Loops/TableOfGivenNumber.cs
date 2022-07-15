using System;
using System.Collections.Generic;
using System.Text;

namespace MyFristProject.Loops
{
    class TableOfGivenNumber
    {
        // Write a progeam to Table from given number using ( For loop)
        static void Main(string[] args)
        {
            int num, mul;
            Console.WriteLine("Enter number");
            num = Convert.ToInt32(Console.ReadLine());
            for(mul=1;mul<=10;mul++)
            {
                Console.WriteLine("{0}*{1}={2}", num, mul,(num*mul));
            }
            
            
 

        }
    }
}
