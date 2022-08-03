using System;
using System.Collections.Generic;
using System.Text;

namespace MyFristProject.OPPS
{                          // constructor is called at the time of object creation.automatlic call
    class TestConstructor //<- Constructor is a special type of method the constructor which is call as
    {                     //  compiler only implicitly is called default constructor if your class does not any constructor
        int A ;
        public TestConstructor()// <- direct calling by object Name without using method
        {
            Console.WriteLine(" Default Constructor");//<-parameterless or default  Constructor
        }

        public TestConstructor(string str)//<- parameterize constructor
        {
            Console.WriteLine("parameter= "+str);
        }


        static void Main(string[] args)
        {
           TestConstructor e = new TestConstructor();
            Console.WriteLine(e.A);
            

            TestConstructor e2 = new TestConstructor("pune");//<- parameter

        }
    }
}
