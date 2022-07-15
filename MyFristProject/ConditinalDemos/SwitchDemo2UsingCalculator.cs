using System;
using System.Collections.Generic;
using System.Text;

namespace MyFristProject.ConditinalDemos
{
    class SwitchDemo2UsingCalculator
    {
        // Calculator using( "Only Switch Case") and Integer  type
        static void Main(string[] args)
        {
            int num1, num2;
            Console.WriteLine(" Enter number 1");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number 2");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("1.Addition\n2.Substraction\n3v  .Multiplication\n4.Division");
            Console.WriteLine(" Enter your choice");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1: Console.WriteLine("Addition =" + (num1+num2));
                    break;
                case 2: Console.WriteLine("Substraction =" +(num1-num2));
                    break;
                case 3: Console.WriteLine("Multiplication =" +(num1*num2));
                    break;
                case 4: Console.WriteLine("Division =" +(num1/num2));
                    break;
                default: Console.WriteLine(" Enter Invalid ");
                    break;
                    Console.ReadKey();

            }
        }
    }
}
