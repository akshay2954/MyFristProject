using System;
using System.Collections.Generic;
using System.Text;

namespace MyFristProject.Inheritane_Demo
{
    class Bird                                               // single level inhertance 
    {
        public void Fly() // parent                           base 2 use for method 
        {
            Console.WriteLine("Bird is fly ");
        }
    }

    class Sparrow : Bird
    {
        public void Fly()
        {
            
            Console.WriteLine("Sparrow Bird is fly ..");
            base.Fly();    // <- base use 2 to call the parent instance method form current instance 
        }

    }
    class BaseKeyworldUse2
    {
        static void Main(string[] args)
        {
            Sparrow s = new Sparrow(); // child class
            s.Fly();                    // call child class method 
        }
    }
}
