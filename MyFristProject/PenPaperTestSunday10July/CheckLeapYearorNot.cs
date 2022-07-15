using System;
using System.Collections.Generic;
using System.Text;

namespace MyFristProject.PenPaperTest
{
    class CheckLeapYearorNot
    {
        // check year is leap or not 
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Year ");
            int year = int.Parse(Console.ReadLine());
            if (((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0))
            {
                Console.WriteLine(" is leap year = " + year);
            }

            else 
            {
                Console.WriteLine(" is not leap year = " + year);
            }
           
            
            
        }
        
        
        
        

    }
}
