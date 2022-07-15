using System;
using System.Collections.Generic;
using System.Text;

namespace MyFristProject.ConditinalDemos
{
    // WAP Find Out number is Positive Negative Or Zero using (" Only Ternary Operator")
    class PositiveNegativeZerousingTernary
    {
        static void Main(string[] args)
        {
            int num1 ;
            Console.WriteLine("Enter A Number");
            num1 = int.Parse(Console.ReadLine());
            string number = num1 > 0 ? " Positive Number" : num1==0 ? "Zero Number " : "Negative Number";
            Console.WriteLine("Ans ="+ number);
            Console.ReadLine();


        }
    }
}
