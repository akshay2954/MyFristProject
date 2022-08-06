using System;
using System.Collections.Generic;
using System.Text;

namespace MyFristProject.Encapsulation
{
    class StaticDemo2
    {
        int x = 10;      //  instance variable 
        static int y = 56;  // static variable 

        void Show()  // instance method 
        {
            Console.WriteLine(x+" "+y);  // local variable 
            staticMethod(); // call static method 
        }

        static void staticMethod() // static method 
        {
           StaticDemo2 d= new StaticDemo2();  //  new object current class 
            Console.WriteLine(d.x+" "+y);// 
           // d.Show();  // call show method use the object refreanse 

            int c=  d.x + y; // Local variable as not static access int static method 
        }
            

        static void Main(string[] args)
        {
            StaticDemo2 s =new  StaticDemo2(); // object 
           // s.Show();

            StaticDemo2.staticMethod();  // call static method 


        }
    }
}
