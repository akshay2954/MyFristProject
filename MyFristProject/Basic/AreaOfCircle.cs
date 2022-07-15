using System;
using System.Collections.Generic;
using System.Text;

namespace MyFristProject.Basic
{
    class AreaOfCircle
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Enter Radious");
            double radious = Convert.ToDouble(Console.ReadLine());
            double area = Math.PI * radious * radious;
            Console.WriteLine("Area of Circle "+ area );
            Console.ReadKey();


        }
    }
}
