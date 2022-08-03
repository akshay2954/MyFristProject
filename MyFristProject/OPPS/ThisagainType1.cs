using System;
using System.Collections.Generic;
using System.Text;

namespace MyFristProject.OPPS
{
    class ThisagainType1
    {
        int a = 10;
        public void input (int a)
        {
            this . a = a;

        }
        public void Display()
        {
            Console.WriteLine("A="+a);
        }
        static void Main(string[] args)
        {
            ThisagainType1 e = new ThisagainType1();
            e.input( 450);
            e.Display();

        }
    }
}
