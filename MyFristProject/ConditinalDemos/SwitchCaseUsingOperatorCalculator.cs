using System;
using System.Collections.Generic;
using System.Text;

namespace MyFristProject.ConditinalDemos
{
    class SwitchCaseUsingOperatorCalculator
    {
        // Calculator using (Switch case And Operator Only)
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number 1");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Number 2");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter The Operator"); ;
            char op = Convert.ToChar(Console.ReadLine());
            switch (op)
            {
                case '+': Console.WriteLine("Addition =" + (num1=num2));
                    break;
                case '-': Console.WriteLine("Substraction ="+ (num1-num2));
                    break;
                case '*': Console.WriteLine("multiplication ="+ (num1*num2));
                    break;
                case '/': Console.WriteLine("Division =" +(num1/num2));
                    break;
                default:
                    Console.WriteLine("Enter Invalid");
                    break;

            }
        }
    }
}
