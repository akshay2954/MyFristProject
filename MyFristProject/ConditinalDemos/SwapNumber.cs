using System;
using System.Collections.Generic;
using System.Text;

namespace MyFristProject.ConditinalDemos
{ 
    class SwapNumber

    {
        // WAP To SwapNumber between 2 number 
        static void Main(string[] args)
        {
            int num1, num2, temp;
            Console.WriteLine("\n Enter Frist number :");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("\n Enter Second Number :");
            num2 = int.Parse(Console.ReadLine());
            temp = num1;
            num1 = num2;
            num2 = temp;

            Console.WriteLine("\n After Swapping :");
            Console.WriteLine("\n Frist Number :" + num1);
            Console.WriteLine("\n Second Number :" + num2);


        }
    }
}
