using System;
using System.Collections.Generic;
using System.Text;

namespace MyFristProject.PenPaperTestSunday10July
{
    class Scalculator
    {
        // Create s simple calculater
        static void Main(string[] args)
        {
            Console.WriteLine("enter number 1");
            int n1 = int.Parse(Console.ReadLine());
        
            Console.WriteLine("enter number2 ");
           
            int n2 = int.Parse(Console.ReadLine());

            Console.WriteLine(" Enter the operator");
            Console.WriteLine("1.+\n2.-\n3.*\n4./");
            char op = Convert.ToChar(Console.ReadLine());
         
            switch (op)
            {
                case '+': Console.WriteLine("Addition="+(n1+n2));
                    break;
                case '-': Console.WriteLine("Substraction="+(n1-n2));
                    break;
                case '*': Console.WriteLine("multiplication="+(n1*n2));
                    break;
                case '/': Console.WriteLine("Divisoin="+(n1/n2));
                    break;
                default:
                    Console.WriteLine("invalid");
                    break;

            }

        }
    }
}
