using System;
using System.Collections.Generic;
using System.Text;

namespace MyFristProject.ConditinalDemos
{
    class NestedDemo
    {
      //WAP to Person want to donate a blood . ( using Nested if else Condition) And ( logical & Operator )
        static void Main(string[] args)
        {
            Console.WriteLine("enter a age");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter a weight");
            int wt = int.Parse(Console.ReadLine());

            if ( age >18 && wt>50)
            {
                Console.WriteLine("The person is valid for blood donation");
            }
            else
            {
                Console.WriteLine("The person is not valid for blood donation try next time.....");
            }


            /* if (age >18)
            {
                if (wt>50)
                {
                    Console.WriteLine("Person is valid fo blood donate");
                }
                else
                {
                    Console.WriteLine("Person age is valid but not weight try next time......");
                }
            }
            else
            {
                Console.WriteLine("Person is not valid for blood donation try next time......");
            }*/
        }    }

}
