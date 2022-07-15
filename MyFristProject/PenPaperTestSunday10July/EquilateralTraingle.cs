using System;
using System.Collections.Generic;
using System.Text;

namespace MyFristProject.PenPaperTest
{
    class EquilateralTraingle
    {
        //wright a program to equilateral traingle 
        static void Main(string[] args)
        {
            float side;
            Console.WriteLine("Enter Side");
            side =int.Parse( Console.ReadLine());
            double area = (Math.Sqrt (3)) / 4 * side * side;
            Console.WriteLine("Area of triangle = "+ area);



        }
    }
}
