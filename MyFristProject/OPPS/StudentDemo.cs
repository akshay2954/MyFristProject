using System;
using System.Collections.Generic;
using System.Text;

namespace MyFristProject.OPPS
{
    class StudentDemo
    {
        //How declared a variable in inside a class
        public int id;
        public string name;
        public double mark;

        static void Main(string[] args)
        {
            StudentDemo e = new StudentDemo();
            e.id = 100;
            e.name = "Akshay";
            e.mark = 79.98;
            Console.WriteLine(e.id+" "+e.name+" "+e.mark);
        }
    }
}
