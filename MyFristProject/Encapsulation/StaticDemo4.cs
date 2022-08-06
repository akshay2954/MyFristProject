using System;
using System.Collections.Generic;
using System.Text;

namespace MyFristProject.Encapsulation
{
    static class StaticDemo4
    {
        static int x = 10;   // static variable 
        static StaticDemo4() // static default constructor
        {
            Console.WriteLine("static default constructor");
        }

        static void Main(string[] args)
        {
          
            Console.WriteLine(x);
        }
    }
}
