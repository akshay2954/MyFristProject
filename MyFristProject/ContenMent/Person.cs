using System;
using System.Collections.Generic;
using System.Text;

namespace MyFristProject.ContenMent
{
                          // Using Constructor 
    class Address
    {
        public int pincode; // instance variable 
        public string city;

        public Address(int pincode, string city) // parameter Constructor 
        {
            this.pincode = pincode; // this use the assign instance variable
            this.city = city;
        }
        public void Show()
        {
            Console.WriteLine("Pincode= "+ pincode);
            Console.WriteLine("City Name ="+ city);
        }
    }
    class Person
    {
        int  id;   // instance variable 
        string name;
        Address adr;

        Person(int id, string name, Address adr) // parameter constructor 
        {
            this.id = id; // this use to assign instance variable 
            this.name = name;
            this.adr = adr;
        }
         
        public void Display() 
        {
            Console.WriteLine("Id= "+id);
            Console.WriteLine("Name= "+ name );
            adr.Show(); // call address show method 
        }
            
        static void Main(string[] args)
        {
            Address a = new Address(443403, " Akola "); // Object Address Constructor 


            Person p;
            p = new Person(101, "Akshay Thakare", a);  // objcet Person Constructor 
            p.Display();  // class person 


           // Person e = new Person(101,"Akshay", new Address (443403,"Akola")); // secont type call annonimous 
        }
    }
}
