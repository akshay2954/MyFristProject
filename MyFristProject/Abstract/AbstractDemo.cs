using System;
using System.Collections.Generic;
using System.Text;

namespace MyFristProject.Abstract
{
    abstract class Animal
    {
        public abstract void Eat(); // abstract method 
        public Animal( int leg) // Anstract constructor 
        {
            Console.WriteLine("Animal ");
            Console.WriteLine("Animal Les= "+ leg);
        }
        public void Run()    // non-abstract method 
        {
            Console.WriteLine("Animal is to big..");
        }
    }
    class Dog : Animal
    {
        public Dog() : base(4)  // abstract constructor call base keyworld frist constructor .
        {

        }

        public override void Eat()   // override Method
        { 
            Console.WriteLine("Dog Eating ..");
        }

    }

    class AbstractDemo
    {
        static void Main(string[] args)
        {
            Dog d = new Dog(); // child class object 
            d.Eat();
            d.Run();

        }
    }
}
