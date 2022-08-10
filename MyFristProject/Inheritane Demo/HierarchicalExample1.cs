using System;
using System.Collections.Generic;
using System.Text;

namespace MyFristProject.Inheritane_Demo
{
    class Father                                            //  Hierarchical
    {
        public string FatherName()
        {
            return  "Manohar";

        }
    }
    class FristChild:Father
    {
        public string ChildName()
        {
            return "Rahul";

        }

    }
    class SecondChild:Father 
    {
        public string ChildName() // method 
        {
            return "Rohit";
        }
    }
    class HierarchicalExample1
    {
        static void Main(string[] args)
        {
            FristChild Frist = new FristChild();  // child object 
            Console.WriteLine("My  Name is "+Frist.ChildName()+" My Father Name is "+Frist.FatherName()+" .");

            SecondChild Second = new SecondChild(); // child object 
            Console.WriteLine("My  Name is " + Second.ChildName() + " My Father Name is " + Second.FatherName() + " .");

        }
    }
}
