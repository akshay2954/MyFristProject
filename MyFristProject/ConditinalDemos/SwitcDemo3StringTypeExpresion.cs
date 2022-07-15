using System;
using System.Collections.Generic;
using System.Text;

namespace MyFristProject.ConditinalDemos
{
    class SwitcDemo3StringTypeExpresion
    {
        // Explain hou to use (simple String in Switch Case)
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string");
            string str = Console.ReadLine();
            switch (str)
            {
                case "happy": Console.WriteLine("Happy");
                    break;
                case "new": Console.WriteLine("New");
                    break;
                case "year": Console.WriteLine("Year");
                    break;

                default : Console.WriteLine(" Welcome");
                    break;



            }
        }
    }
}
