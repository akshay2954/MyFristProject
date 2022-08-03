using System;
using System.Collections.Generic;
using System.Text;

namespace MyFristProject.OPPS
{
    class ConstructorCar
    {
        string car_name;
        string model_Number ;

        public ConstructorCar(): this("BMW"," 8i ")// default  constructor 
        {
            Console.WriteLine("Default Constructor car");
        }
        public ConstructorCar(string car_name, string model_Number )  // parameter constructor 
        {
            this.car_name = car_name;
            this.model_Number = model_Number;
            show(); 
        }
        public void show()
        {
            Console.WriteLine(car_name+" "+ model_Number);
            
        }
  
    }

   class Thiskeyworld3
   {

    
        static void Main(string[] args)
        {
            ConstructorCar BMW = new ConstructorCar();

            //ConstructorCar Audi = new ConstructorCar("Audi","Q7");
           // Audi.show();
            


        }
    }
}
