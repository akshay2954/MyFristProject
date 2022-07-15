using System;
using System.Collections.Generic;
using System.Text;

namespace MyFristProject.ConditinalDemos
{
    class SwitchUsingAreaProperties
    { 
        static void Main(string[] args)
        {
            Console.WriteLine("Result\n--------------------------------------------------------");
            Console.WriteLine("1.Area of Rectagle\n2.Area of circle\n3.Area of Traingle\n4.Area of Squre");
            Console.WriteLine(" Enter your Choice");
            int choice = int.Parse(Console.ReadLine());
            switch( choice)
            {
                case 1:
                    Console.WriteLine("Enter Number 1");
                    int width = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Number 2 ");
                    int height = int.Parse(Console.ReadLine());
                    Console.WriteLine(" Area of Rectangle = " + (width*height) );
                    break;
                case 2:
                    Console.WriteLine("Enter Number 1");
                    int R = int.Parse(Console.ReadLine());
                    Console.WriteLine("Area Of Circle = " + ( 3.14 *R*R));
                    break;
                case 3:
                    Console.WriteLine(" Enter Number 1");
                    int breath = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Number 2");
                    int Height = int.Parse(Console.ReadLine());
                    Console.WriteLine("Area Of Traingle = " + (breath*Height)/2);
                    break;
                case 4:
                    Console.WriteLine("Enter Number 1");
                    int side = int.Parse(Console.ReadLine());
                    Console.WriteLine(" Area Of Squre = " + (side*side));
                    break;
                    Console.ReadLine();

               
                    

            }
        }
    }
}
