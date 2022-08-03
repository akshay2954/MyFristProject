using System;
using System.Collections.Generic;
using System.Text;

namespace MyFristProject.Encapsulation
{
    class Typepromotion
    {
        void Addition( int x, float  z )
        {
            Console.WriteLine(x+z);
        }
        static void Main(string[] args)
        {
            Typepromotion t = new Typepromotion();
            // t.Addition(7, 7.5);    // Type Demontion
              t.Addition(7, 5);      // type promation
        }
    }
}
