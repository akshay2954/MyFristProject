using System;
using System.Collections.Generic;
using System.Text;

namespace MyFristProject.Encapsulation
{
    class AreaOverLoading
    {
        // calculate the are of traingle , rectangle, cricle, square .
        void area()
        {
           Console.WriteLine("Area Method ");
        }

        float area (float b,float h)
        {
            return (b * h) / 2;
        }
        double area (double r) 
        {
            return (3.14 * r * r);
        }

        int area (int a)
        {
            return (a * a);
        }
        int area(int z,int y)
        {
            return (z * y);
        }

        static void Main(string[] args)
        {
            AreaOverLoading a = new AreaOverLoading();
            a.area();

            float f=a.area(12,5);
            Console.WriteLine("Area of Traningle= "+ f);

            double d = a.area(5.5);
            Console.WriteLine("Area of circel= "+ d);

            int i = a.area(5);
            Console.WriteLine("Area of square ="+ i);

            int i2 = a.area(10,20);
            Console.WriteLine("Area of Square= "+ i2); 


        }
    }
}
