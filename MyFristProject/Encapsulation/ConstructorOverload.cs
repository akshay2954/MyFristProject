using System;
using System.Collections.Generic;
using System.Text;

namespace MyFristProject.Encapsulation
{
    class Mobile
    {
        int price;
        string name;
        string memory;
        public Mobile (string name)
        {
            this.name = name;
            Console.WriteLine("name= " + name);
           
        }
        public Mobile(int price, string memory)
        {
            this.price = price;
            this.memory = memory;
            this.Display();
        }
       void Display ()
       {
            
            Console.WriteLine("Price="+ price);
            Console.WriteLine("Memory=" + memory);
       }
    }
    class ConstructorOverload
    {
        static void Main(string[] args)
        {
            Mobile M = new Mobile ("OnePlus1");

            Mobile m1 = new Mobile(54000, "128GB");
        } 

        
    }
}
