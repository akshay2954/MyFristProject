using System;
using System.Collections.Generic;
using System.Text;

namespace MyFristProject.Encapsulation
{
    class StaticDemo3
    {
       static StaticDemo3() 
        {
            Console.WriteLine(" static Defalut Constructor ");
        }

        StaticDemo3()
        {
            Console.WriteLine("Non static Defalut Constructor ");
        }

        static void Main(string[] args)
        {
            StaticDemo3 s = new StaticDemo3();
            StaticDemo3 s2 = new StaticDemo3();
        }
    }
}
