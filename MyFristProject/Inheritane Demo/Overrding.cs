using System;
using System.Collections.Generic;
using System.Text;

namespace MyFristProject.Inheritane_Demo
{
    class Fruit
    {
       public virtual void Test ()       // method singn..same   use virtual 
        {
            Console.WriteLine("Sweet fruit ");
           
        }
    }
    class Mango :Fruit 
    {
        public override  void Test()      // method singn..same  use override 
        {
            Console.WriteLine("Mango is sweet ");
            base.Test();
           
        }
    }
    class Orange: Fruit                                               
    {
        public override void Test()   // method singn..same      use override 
        {
            Console.WriteLine(" orange is orange colour ");
            
            
           
        }
    }

    class Overrding
    {
        static void Main(string[] args)
        { 
            Fruit m = new Mango ();  // objcet dinamic binding 
            m.Test();

            Fruit m2 = new Orange();
            m2.Test();
        }
    }
}
