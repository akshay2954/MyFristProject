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
            int n1, n2, n3;
            Console.WriteLine(" Enter Number 1");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Enter Number 2");
            n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Enter Number 3");
            n3 = Convert.ToInt32(Console.ReadLine());

            string number = n1 > n2 ? "number 1 large" : n2 > n3 ? "number 2 large" : "number 3 large";
            Console.WriteLine(" Ans =" + number);
            Console.ReadKey();
            

        }
    }
}
