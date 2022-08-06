using System;
using System.Collections.Generic;
using System.Text;

namespace MyFristProject.Inheritane_Demo
{                                                      // single level inheritance 
    class Mobile  // parent 
    {
        internal string memory_size = " 64 GB";
    }
    class Apple : Mobile //  child parant 
    {
        public void show()  
        {
            Console.WriteLine("iphone= " +memory_size);
        }
    }
    class SingleDemo
    {
        static void Main(string[] args)
        {
            Apple iphone= new Apple();
            iphone.show();
                Console.WriteLine( "iphone = "+iphone.memory_size ); // direct accesss 
        }
    }
}
