using System;
using System.Collections.Generic;
using System.Text;

namespace MyFristProject.New_OPPS
{
    class CarAverage
    {
        // Print Car Average.
        public string  Model_name;
        public string type;
        public int wheels;

        public void AcceptDetails(string eModel_name , string etype, int ewheels)
        {
            Model_name = eModel_name;
            type = etype;
            wheels = ewheels;
        }

        public void  Average()
        {
            if (wheels==4)
            {
                Console.WriteLine("Average is 15");
            }
            else if (wheels== 2)
            {
                Console.WriteLine("Average is 45");
            }
        }

        public void Display()
        {
            Console.WriteLine(Model_name+" "+ type+" "+wheels);
        }
        static void Main(string[] args)
        {

            CarAverage e = new CarAverage();
            e.AcceptDetails( "V4","SUV ",4);
            e.AcceptDetails("Q1", "Bike", 2);
            e.Average();
            e.Display();


        }
    }
}
