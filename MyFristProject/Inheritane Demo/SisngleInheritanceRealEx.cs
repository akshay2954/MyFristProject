using System;
using System.Collections.Generic;
using System.Text;

namespace MyFristProject.Inheritane_Demo
{
    class Shap // parent                                      // single level inhertnce real time example 
    {
        public double widht;
        public double height;
        public void show ()
        {
            Console.WriteLine("Width and Height are"+widht+" and "+ height);
        }
    }
    class Trangle : Shap  // parent child  relation
    {
        public string style;
        public double Area()
        {
            return widht * height / 2;
        }
        public void showstyle()
        {
            Console.WriteLine("Trangle is "+ style);
        }
    }
    class SisnglecwInheritanceRealEx
    {
        static void Main(string[] args)
        {
            Trangle t = new Trangle();
            t.widht = 4.0;
            t.height = 5.0;
            t.style = "isosceles";

            Trangle t2 = new Trangle();   //  child object 
            t2.widht = 8.0;
            t2.height = 12.0;
            t2.style = "Right";

            Console.WriteLine("Info For t1:");
            t.showstyle();
            t.show();
            Console.WriteLine("Area is +"+t.Area());
            Console.WriteLine();
            Console.WriteLine("Info for t2:");
            t2.showstyle();
            t2.show();
            Console.WriteLine("Area is +"+ t2.Area());



        }
    }
}
