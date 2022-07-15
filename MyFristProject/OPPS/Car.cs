using System;
using System.Collections.Generic;
using System.Text;

namespace MyFristProject.OPPS
{
    class Car
    {
        // assign tha date of car and create a object inside the mmain method
      public    string  model_Number;
      public    string  name;
      public    double price;

        public void AcceptDetails(string ename, string emodel , double eprice)
        {
          
           name = ename;
           model_Number = emodel;
           price = eprice;
        }
        public void Display()
        {
            Console.WriteLine(name+" "+model_Number+" "+price);
        }

             
        static void Main(string[] args)
        {

            Car e= new Car();
            e.AcceptDetails("Audi","Q7",8900000);
            e.Display();
            Car e1 = new Car();
            e1.AcceptDetails( "Swift Dzire", "8899" ,700000);
            e1.Display();

       
           
        }
    }
}
