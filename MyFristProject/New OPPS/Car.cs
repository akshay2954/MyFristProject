using System;
using System.Collections.Generic;
using System.Text;

namespace MyFristProject.New_OPPS
{
    class Car
    {
        public string  model_Number;
        public string  car_name;
        public double car_price;
        public string car_colour;

        static void Main(string[] args)
        {
            Car audi = new Car();
            audi.car_name = "Audi";
            audi.model_Number = "Q7";
            audi.car_price = 5000000;
            audi.car_colour = "white";

            Car BMW = new Car();
            BMW.car_name = "BMW";
            BMW.model_Number = "i8";
            BMW.car_price = 6000000;
            BMW.car_colour = "Black";

            Car Range_Rover = new Car();
            Range_Rover.car_name = "Range Rover Vogue";
            Range_Rover .model_Number = "4x4 Sport utility vehicle";
            Range_Rover .car_price = 26000000;
            Range_Rover.car_colour = "Black";

            Console.WriteLine(audi.car_name+" "+audi.model_Number+" "+audi.car_price+" "+audi.car_colour+" ");
            Console.WriteLine(BMW.car_name + " " + BMW.model_Number + " " +BMW.car_price + " " +BMW.car_colour + " ");
            Console.WriteLine(Range_Rover.car_name + "  " + Range_Rover.model_Number + "  " + Range_Rover.car_price + "  " + Range_Rover.car_colour + "  ");
        }

    }
}
