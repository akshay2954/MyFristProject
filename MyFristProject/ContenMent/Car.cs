using System;
using System.Collections.Generic;
using System.Text;

namespace MyFristProject.ContenMent
{
    class Engine
    {
        string type;
        public string Type  // Property writing 
        {
            get { return type; }
            set { type = value; }
        }
    }
    class Car
    {
        int modelnumber;
        string Cname;
        int price;
        Engine en;

        public int ModelNumber  // property
        {
            get { return modelnumber; }
            set { modelnumber = value; }
        }

        public string CName   // property
        {
            get;
            set;
        }

        public int Price // proberty
        {
            get { return price; }
            set { price = value; }
        }

        public Engine En // property    non primitive type
        { 
            get { return en; }
            set { en = value; }
        }

    }

    class CarInfo
    {
        static void Main(string[] args)
        {
            Car c = new Car();    
            c.ModelNumber = 5738;   //  call set method 
            c.CName = "Audi";
            c.Price = 569000;
            c.En = new Engine();    // Engine class object
            c.En.Type = "Petrol";

            Console.WriteLine("Model Number="+c.ModelNumber);  // call get method 
            Console.WriteLine("Car Name =" + c.CName);
            Console.WriteLine("Car Price= "+c.Price );
            Console.WriteLine("Engine Type= "+c.En.Type);   // call Engin Propety

        }    
    }
    





}
