using System;
using System.Collections.Generic;
using System.Text;

namespace MyFristProject.Inheritane_Demo
{
    class Laptop // inhertance                                       single level inhertance 
    {
        public Laptop(int num)    //  parameter constructor           use 3 for call the parameter constructor 
        {
            Console.WriteLine("Laptop "+num);
        }

    }

    class Dell : Laptop // inhertnace 
    {  
        public Dell(int x ,int y ) :base(x) //  default constructor base use 3 
        {
            Console.WriteLine("Dell");
        }
    }


    class BaseKeyworldUse3
    {
        static void Main(string[] args)
        {
            Dell d = new Dell(5, 10); // dell class constructor object 
        }
    }
}
