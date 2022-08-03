using System;
using System.Collections.Generic;
using System.Text;

namespace MyFristProject.OPPS
{ 
    class CarSuv
    {
        // 3 Type of use thiskeyworld 
       String car_name;
        String Model_Number;
        public CarSuv():this("BMW","8i")
        {
            Console.WriteLine("Default Car"); //<- default Constructor
        }

        public CarSuv(String car_name, String Model_Number)//<- parameteriz constructor
        {
            this.car_name = car_name;
            this.Model_Number = Model_Number;
            show();
        }

        public void show() //<- show method-
        {
            Console.WriteLine(car_name+" "+Model_Number);
        }


    }




    class ThisKeyworld
    {
        static void Main(string[] args)
        {
          CarSuv BMW = new CarSuv();

           // CarSuv Audi = new CarSuv("Audi","Q7");
            
        } 
    }
}
