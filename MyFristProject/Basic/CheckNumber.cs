using System;
using System.Collections.Generic;
using System.Text;

namespace MyFristProject.Basic
{
    class CheckNumber
    {
        static void Main (string[] args)
        {
            int num;
            Console.Write("\n\n");
            Console.Write(" Check weather a number positive or negative: \n");
            Console.Write("------------------------------------------------");
            Console.Write("\n\n");
            Console.Write("input in integer:  ");
            num = Convert.ToInt32(Console.ReadLine());
            if (num >= 0)

                Console.WriteLine(" {0} is positive number. \n", num);
            else
                Console.WriteLine(" {0}  is a negative number. \n", num);


             
        }
    }
}
