using System;
using System.Collections.Generic;
using System.Text;

namespace MyFristProject.Encapsulation
{



    class CarProperty
    {
        string model_number;
        public string Model_Number
        {
            get
            {
                return model_number;

            }
            set
            {
                model_number = value;
            }
        }
    }
    class Car1
    { 
        static void Main(string[] args)
        {

            CarProperty c = new CarProperty();
            c.Model_Number = "i8";
            Console.WriteLine(" BMW "+ c.Model_Number);
        }
    }
}
