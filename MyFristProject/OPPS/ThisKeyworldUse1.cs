using System;
using System.Collections.Generic;
using System.Text;

namespace MyFristProject.OPPS
{
    class ThisKeyworldUse1
    {
        int x = 10;
        public void input(int x)
        {
             this. x = x;//<- assign to value into x in local variable into input method.
        }
        public void show()
        {
            Console.WriteLine("X="+ x);
        }
        static void Main(string[] args)
        {
            ThisKeyworldUse1 e = new ThisKeyworldUse1();
            e.input(450);
            e.show();
        }
    }
}
