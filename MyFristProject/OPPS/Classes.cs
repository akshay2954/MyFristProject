using System;
using System.Collections.Generic;
using System.Text;

namespace MyFristProject.OPPS
{ 

     // 3 Type of this keyworld in one application
    class Details
    {
        public string name;
        public double fees;
        public Details()//:this("Akshay Thakare", 153400)
        {
            Console.WriteLine("ThinkQuotient Software Private Limited");
        }
        public Details (string name,double fees):this()
        {
            this.name = name;
            Console.WriteLine("Name ="+ name);
         
            this.fees = fees;
            Console.WriteLine("fees = " + fees);
            
        }
     /* public void show()
        {
            Console.WriteLine(name+" "+fees);


        }*/

    }



    class Classes
    {
        static void Main(string[] args)
        {
         //   Details informationc= new Details();
            Details information = new Details("Akshay Thakare", 153400);
            

        }

    }
}
