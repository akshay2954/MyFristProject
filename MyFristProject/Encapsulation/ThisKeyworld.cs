using System;
using System.Collections.Generic;
using System.Text;

namespace MyFristProject.Encapsulation
{
    class ThisKeyworld
    {
        public string name;
        public double fees;

        public ThisKeyworld()
        {
            Console.WriteLine(" Total Fees ");
        }

        public ThisKeyworld(string name, double fees): this ()
        {
            
            this.name = name;
            this.fees = fees;
            show();
        }

        public void show()
        {
            Console.WriteLine(name + " " + fees);
        }
    }
    class Thisdemo
    {
        static void Main(string[] args)
        {
           // ThisKeyworld t = new ThisKeyworld();

            ThisKeyworld t2 = new ThisKeyworld("Akshay Thakare",20000);
        }
    }
}
