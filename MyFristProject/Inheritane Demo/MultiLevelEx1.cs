using System;
using System.Collections.Generic;
using System.Text;

namespace MyFristProject.Inheritane_Demo
{
    class Human                                      // Multilevel Inheritance example with constructor 
    {
        public string name;
        public Human(string na)
        {
            name = na;
        }
    }
    class Man : Human
    {
       public  int age;
        public Man(int age,string name ):base(name )       // parameter Constructor 
        {
            this.age = age;
        }
    }
    class Employeee : Man                                   // grand parant ,parant ,child 
    {
        public int emp_id;
        public int emp_sal;
        public Employeee(int id,int salary,string name ,int age ):base(age, name )
        {
            emp_id = id;
            emp_sal = salary;
        }

        public void show()
        {
            Console.WriteLine("Employeee Id  = "+ emp_id);
            Console.WriteLine("Employeee Salary = "+ emp_sal);
            Console.WriteLine("Employeee age = "+ age);
            Console.WriteLine("Employeee Name  = "+ name );
        }


    }


    class MultiLevelEx1
    {
        static void Main(string[] args)
        {
            Employeee e = new Employeee(101, 35000, "Akshay", 24);
            e.show();

        }
    }
}
