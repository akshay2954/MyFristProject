using System;
using System.Collections.Generic;
using System.Text;

namespace MyFristProject.OPPS
{
    class StudentDetails2
    {
        int id;
        string name;
        double mark;
        public void AcceptDetails( int eid, string ename, double emark)
        {
            id = eid;
            name = ename;
            mark = emark;

        }
        public void Display ()
        {
            Console.WriteLine(id+" "+name+" "+mark+" ");
        }
        static void Main(string[] args)
        {
            StudentDetails2 e = new StudentDetails2();
            e.AcceptDetails(101, "Akshay", 89);
            e.Display();
        }


    }
}
