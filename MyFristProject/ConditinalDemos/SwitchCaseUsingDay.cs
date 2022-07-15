using System;
using System.Collections.Generic;
using System.Text;

namespace MyFristProject.ConditinalDemos
{
    class SwitchCaseUsingDay
    {
        // display Day ( "Using Switch Case")
        static void Main(string[] args)
        {

            Console.WriteLine("Result:\n-----------------------------------------------");
            Console.WriteLine("1.Sunday\n2.Monday\n3.Tuesday\n4.Wednesday\n5.Thursday\n6.Friday\n7.Saturday");
            Console.WriteLine("Enter your 1 to 7 Choise");
            int choice = int.Parse(Console.ReadLine());
            switch(choice)
            {
                case 1: Console.WriteLine("Sunday");
                    break;
                case 2:
                    Console.WriteLine("Monday");
                    break;
                case 3:
                    Console.WriteLine("Tuesday");
                    break;
                case 4:
                    Console.WriteLine("Wednesday");
                    break;
                case 5:
                    Console.WriteLine("Thursday");
                    break;
                case 6:
                    Console.WriteLine("Friday");
                    break;
                case 7:
                    Console.WriteLine("Saturday");
                    break;
                default:
                    Console.WriteLine("You Enter Invalid, Please Enter number between 1 to 7 ");
                    break;
                    Console.ReadKey();



            }
        }
    }
}
