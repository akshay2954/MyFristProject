using System;
using System.Collections.Generic;
using System.Text;

namespace MyFristProject.Inheritane_Demo
{
    class Animal    // parent                        // hierarchical inhertance 
    { 
        public int leg = 4;                           // base 1 use for variable 
    }

    class Frog: Animal   // inhertance       
    {
        public int leg = 2; 
       public void show()
        {
            Console.WriteLine("legs = "+leg);
            Console.WriteLine("Animal Legs= "+base.leg); // base use 1 to call the parent property form child class 
        }
    }

    class Dog :Animal // inheritance 
    {
        public void ShowDog()
        {
            Console.WriteLine("Dog leg= "+base.leg); // base use call parent property
        }
    }

    class BaseKeyworldUse1    
    { 
        static void Main(string[] args)
        {
            Frog f = new Frog();  // objcet frog child class 
            f.show();            // call frog class method 

            Dog d = new Dog();   // Dog class object 
            d.ShowDog();         // call dog class method 
        }
    }
}
