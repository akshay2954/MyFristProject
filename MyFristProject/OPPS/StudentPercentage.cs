using System;
using System.Collections.Generic;
using System.Text;

namespace MyFristProject.OPPS
{
    class StudentPercentage
    {
        public int id;
        public string name;
        public double physic, math, biology;
        public double total;
        public double percentage;

        public void AcceptDetails(int eid, string ename, double ephysic, double emath, double ebiology)
        {
            id = eid;
            name =ename;
            physic = ephysic;
            math = emath;
            biology = ebiology;
        }
        
        public void Fromula()
        {
            total = physic + math + biology;
            percentage = total / 3;

        }
         public void Display()
        {
            Console.WriteLine(id+" "+name+" "+physic+" "+math+" "+biology);
            Console.WriteLine("Total Marl= " + total);
            Console.WriteLine("Total Percentage = "+ percentage);
        }


        static void Main(string[] args)
        {
          /*StudentPercentage a = new StudentPercentage();
            a.AcceptDetails(101, "Akshay", 79, 91, 85);
            a.Display();*/
            StudentPercentage a1 = new StudentPercentage();
            Console.WriteLine("Enter student id");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter student name ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Student Physic ");
            int physic = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter student Math");
            int math = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter student Biology");
            int biology= int.Parse(Console.ReadLine());
            a1.AcceptDetails(id,name,physic,math,biology);
            a1.Fromula();
            a1.Display();


        }
    }
}
