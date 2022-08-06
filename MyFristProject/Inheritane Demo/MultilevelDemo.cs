using System;
using System.Collections.Generic;
using System.Text;

namespace MyFristProject.Inheritane_Demo
{
    class Person         // grand parent           1             // multilevel inheritance 
    {
        internal string p_name = "Akshay ";
        public void showperson()
        {
            Console.WriteLine("Person Name= "+ p_name);
        }

    }
    class Employee : Person // parent                   2
    {
        internal int sal = 35000;
        public void showsal()
        {
            Console.WriteLine("Name= "+ p_name );
            Console.WriteLine("salary="+sal);
        }

    }
    class Manegar: Employee // child                   3
    {
        internal int commition = 1500;
       public void showmanager()
        {
            Console.WriteLine("Commition="+ commition);
            Console.WriteLine("salary= "+ sal);
            Console.WriteLine("Name= "+ p_name );
        }
    }


    class MultilevelDemo
    {
        static void Main(string[] args)
        {
            Manegar m = new Manegar();
            m.showperson();
            m.showsal();
            m.showmanager();
        }
    }
}
