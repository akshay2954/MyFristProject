using System;
using System.Collections.Generic;
using System.Text;

namespace MyFristProject.OPPS
{
    class Employee
    {
        public int id;
        public string name;
        public double salary;

        public void AcceptDetails(int eid, string ename, double esal)
        {
            id = eid;
            name = ename;
            salary = esal;
        }
        
        public void Display()
        {
            Console.WriteLine(id+" "+name+" "+salary);
        } 

        static void Main(string[] args)
        {
            Employee e = new Employee();
            e.AcceptDetails(27, "Akshay", 20000);
            e.Display();
            Employee e1 = new Employee();
            Console.WriteLine("Enter Employee Id");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("enter employee name ");
            string name = Console.ReadLine();
            Console.WriteLine("enter employee salary");
            int salary = int.Parse(Console.ReadLine());

            e1.Display();


        }
    }
}
