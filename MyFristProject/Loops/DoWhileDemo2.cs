using System;
using System.Collections.Generic;
using System.Text;

namespace MyFristProject.Loops
{
    class DoWhileDemo2
    {
        static void Main(string[] args)
        {
            // Menu Driven program ( Do While Loop_)
            char ch;
            do
            {
                Console.WriteLine("Enter Number 1 ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("EEtnet number 2");
                int num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter your choose");
                Console.WriteLine("1.+\n2.-\n3.*\n4./");
                char op = Convert.ToChar(Console.ReadLine());
                switch (op)
                {
                    case '+':
                        Console.WriteLine("Addition " + (num1 + num2));
                        break;
                    case '-':
                        Console.WriteLine("substraction " + (num1 - num2));
                        break;
                    case '*':
                        Console.WriteLine("multipliction " + (num1 * num2));
                        break;
                    case '/':
                        Console.WriteLine("division " + (num1 / num2));
                        break;
                    default:
                        Console.WriteLine("enter Invalid");
                        break;
                }
                Console.WriteLine("Do you want to continue");
                ch = Convert.ToChar(Console.ReadLine());
                 
            } while (ch=='y'||ch=='Y');



        }
    }
}
