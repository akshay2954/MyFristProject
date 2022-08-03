using System;
using System.Collections.Generic;
using System.Text;

namespace MyFristProject.Encapsulation
{
    class StudentConstructor
    {
        // Explain Constructor.

         string name;
         int id;
         double per;

        public StudentConstructor () // default constructor or noparameterr 
        {
            /* name = "Akshay Thakare ";
             id = 101;
             per = 73.60;*/
            Console.WriteLine("Default Constructor ");
        }
        
        public StudentConstructor(string ename,int eid, double eper ) // parameter constructor 
        {
            name = ename;
            id = eid;
            per = eper;

        }
        static void Main(string[] args)
        {
            //StudentConstructor s = new StudentConstructor();
            // Console.WriteLine(s.name+" "+ s.id+" "+s.per);

            StudentConstructor s1 = new StudentConstructor();
            //Console.WriteLine(s1.name+" "+ s1.id+" "+s1.per);


            StudentConstructor s2 = new StudentConstructor( "Akshay Thakare ", 101, 73.60);
            Console.WriteLine(s2.name+" "+s2.id+" "+s2.per);
           


        } 
    }
}
