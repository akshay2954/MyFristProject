﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MyFristProject.Loops
{
    class DigitofSumcs
    {
        // Write a program to Sum of Digit using ( while loop)
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number ");
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            while(num>0)
            {
                int r = num % 10;
                sum = sum + r;
                num = num / 10;
            }
            Console.WriteLine("Sum ="+ sum);
               

        }
    }
}
