using System;
using System.Collections.Generic;
using System.Text;

namespace MyFristProject.ConditinalDemos
{
    class LargThreeNumberOnlyusingTernary
    {
        //Fine out large Three number using ( "Only Ternary Operator")
        static void Main(string[] args)
        {
            
            string number;  // <- string is use for AlphaNumeric Value ... 

            Console.WriteLine(" Enter Number 1");
            int  n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Enter Number 2");
            int  n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Enter Number 3");
            int   n3 = Convert.ToInt32(Console.ReadLine());

            number = n1 > n2 ? "number 1 large" : n2 >  n3 ? "number 2 large" : "number 3 large";
            Console.WriteLine(" Ans =" + number);
            Console.ReadKey();
            

        }
    }
}
