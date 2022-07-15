using System;
using System.Collections.Generic;
using System.Text;

namespace MyFristProject.Loops
{
    class Countdigit
    {
        // Count number of digit get from user input  number using (while loop)
        static void Main(string[] args)
        {
            Console.WriteLine("enter digit ");
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            while(n!=0)
            {
               
                   n = n/10;
                   count++;
               
               
            }
            Console.WriteLine( "count of digit ="+count);
            

        }
    }
}
