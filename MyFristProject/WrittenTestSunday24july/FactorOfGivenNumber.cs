using System;
using System.Collections.Generic;
using System.Text;

namespace MyFristProject.WrittenTestSunday24july
{
    class FactorOfGivenNumber
    {
        //2.) Write a program to print all factors of given numbers
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number ");
            int num = int.Parse(Console.ReadLine());
            int fact = 1;
            for (int i = 1; i <= num; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine("Factorial of Number is :" + fact);

        }
    }
}
