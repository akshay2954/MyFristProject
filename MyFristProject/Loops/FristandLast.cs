using System;
using System.Collections.Generic;
using System.Text;

namespace MyFristProject.Loops
{
    class FristandLast
    {
        static void Main(string[] args)
        {
            int num;
            float sum = 0;
            int fristdigit;
            int lastdigit;
            Console.WriteLine("Enter number");
            num = int.Parse(Console.ReadLine());
            lastdigit = num % 10;
            fristdigit = num;
            while (num >=10)
            {
                num = num / 10;
            }
            fristdigit = num;
           
            sum = fristdigit + lastdigit;

            Console.WriteLine("Sum of frist and Lastdigit ="+ sum);
            Console.ReadLine();
     


        }
    }
}
