using System;
using System.Collections.Generic;
using System.Text;

namespace MyFristProject.OPPS
{
    class ThisKeyworldUse2
    {
        public void input()
        {
            Console.WriteLine("input method");
            this.show();//<--  Direct calling one method to another method use this keyworkd 
        }
        public void show()
        {
            Console.WriteLine("show method");
        }
        static void Main(string[] args)
        {
            ThisKeyworldUse2 e = new ThisKeyworldUse2();
            e.input();//<-- calling input method
           // e.show();
        }
    }
}
