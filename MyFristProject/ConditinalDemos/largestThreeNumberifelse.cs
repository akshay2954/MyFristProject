using System;
using System.Collections.Generic;
using System.Text;

namespace MyFristProject.ConditinalDemos
{
    class largestThreeNumberifelse
    {
        // find out largest 3 number using( if else)
        static void Main(string[] args)
        {

            Console.WriteLine(" Enter number 1");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Enter Number 2");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Enter Number 3");
            int n3 = Convert.ToInt32(Console.ReadLine());

            if (n1 > n2 && n1 > n3)
                Console.WriteLine("Number 1 Large =" + n1);
            else if (n2 > n1 && n2 > n3)
                Console.WriteLine("Number 2 Large= " + n2);
            else
                Console.WriteLine("Number 3 Large= " + n3);

            
            Console.WriteLine("Press any key enter to exit");
            Console.ReadKey();


                
        }
    }
}
