using System;
using System.Collections.Generic;
using System.Text;

namespace MyFristProject.Inheritane_Demo
{

                                                     // Hirachical inheritanec
    class Vehical  // one parent 
    {
            protected int wheels = 4;

    }
    class Car : Vehical  // multiple child
    {
        internal string c_name = "Audi ";
        public void showcar()
        {
            Console.WriteLine("Car Name=" + c_name);
            Console.WriteLine("wheel =" + wheels);
        }
    }
    class Truck : Vehical // multiple  child 
    {
          public void showtruck()
          {
                 wheels = 10;
                    Console.WriteLine("Truck Wheels="+ wheels);
          }
    }
        
    class HirachicalDemo
    {
        static void Main(string[] args)
        {
            Car c = new Car();  // car class object
            c.showcar(); // call method 

            Truck t = new Truck();
            t.showtruck();


        }
    }
}
