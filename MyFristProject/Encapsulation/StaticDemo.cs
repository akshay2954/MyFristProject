using System;
using System.Collections.Generic;
using System.Text;

namespace MyFristProject.Encapsulation
{
    class StaticDemo
    {
       static  int x = 0;   // static variable 
        StaticDemo()   // non static nconstructor 
        {
            x++;
            Console.WriteLine(x);
        }
        
        void Display()// non static instance method 
        {
            Console.WriteLine(x);
        }

        static int Addition ()// static method 
        {
            return 3 + 2;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(x);


            StaticDemo s = new StaticDemo();// object 
           /* StaticDemo s1= new StaticDemo();
            StaticDemo s2 = new StaticDemo();*/

            // Console.WriteLine(s.x);//     static always never work with object 

            Console.WriteLine(StaticDemo.x); // static always  work with class  (

            int ans = StaticDemo.Addition();//  call the method as the class name 
            Console.WriteLine("Addition = "+ans);
        }
    }
}
