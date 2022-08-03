using System;
using System.Collections.Generic;
using System.Text;

namespace MyFristProject.Encapsulation
{
    class MethodOverLOadingDemo
    {
        void show ()                                       //  1 method 
        {
            Console.WriteLine("Show Method ");
        }
        void show(string str , int x)                     // 2 method 
        {
            Console.WriteLine(str+" "+ x);
        }
        int show (int a, int b)                           // 3 method 
        {
            return a - b;
        }
        void show (float x )                             // 4 method 
        {
            Console.WriteLine(x);
        }
        static void Main(string[] args)
        {
            MethodOverLOadingDemo m = new MethodOverLOadingDemo();

            m.show();                           // call 1 method    with different type 

            Console.WriteLine(m.show(10,20));   // call 2 method 

            int ans =  m.show(5, 10);           // call 3 method 
            Console.WriteLine(ans);

            m.show(87.3f);                      // call 4 method 



        }
    }
}
