using System;
using System.Collections.Generic;
using System.Text;

namespace MyFristProject.PenPaperTest
{
    class DivisibleFive
    {
        // check number dividible by 5 and 11 or not 
        static void Main(string[] args)
        {
            Console.WriteLine("enter Number ");
            int  num1 = int.Parse(Console.ReadLine());
           
            

            if ((num1%5==0) && (num1%11==0))
            {
                Console.WriteLine("Divesible By Both 5 and 11 = "+ num1);
            }
            else
            {
                Console.WriteLine("not divisible by 5 and 11");
            }

        }
    }
}
