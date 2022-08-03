using System;
using System.Collections.Generic;
using System.Text;

namespace MyFristProject.OPPS
{
    class ThisAgainType2
    {
        public void input ()
        {
            Console.WriteLine("input method  ");

        }
        public void show()
        {
            Console.WriteLine("show method");
        }
        static void Main(string[] args)
        {
            ThisAgainType2 e= new ThisAgainType2();
            e.input();
            e.show();

        }
    }
}
