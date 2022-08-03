using System;
using System.Collections.Generic;
using System.Text;

namespace MyFristProject.Encapsulation
{
    class Employeedetails
    {
        internal string name;
        internal int id;
        internal double sal;
        public Employeedetails(string name, int id, double sal) //parameter constructor  
        {
            this.name = name; // 1 use of this  instance and local variable name 
            this.id = id;
            this.sal = sal;
        }
        public void Display()
        {
            Console.WriteLine(name + " " + id + " " + sal);
        }
    }
    class ThisUse
    { 
        static void Main(string[] args)
        {
            Employeedetails e = new Employeedetails("Akshay Thakare ", 78, 35000);
            e.Display();

            Car3 c = new Car3(3784, "Audi ", 764888);
            

        }
    }
    class Car3
    {
         int  model;
         string name;
         double price;

        public Car3(int model,string name,double price) // parameter constructor
        {
            this.model = model;
            this.name = name;
            this.price = price;
            this.show();  // 2 use of this keyworld call method without using main method.
        }
        public void show()
        {
            Console.WriteLine(model+" "+name+" "+price);
        }

    }
}
