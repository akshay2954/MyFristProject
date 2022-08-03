using System;
using System.Collections.Generic;
using System.Text;

namespace MyFristProject.OPPS
{
    class ConstructorAgain
    {
        // how to work constructor 
       string x;
        public ConstructorAgain()
        {
            Console.WriteLine("Default Constructor or Parameterless constructor ");

        }  
        public ConstructorAgain( string state )
        {
            Console.WriteLine(" Parameterize Constructor="+ state);
        }
        static void Main(string[] args)
        {
            ConstructorAgain e = new ConstructorAgain(); 
            Console.WriteLine(e.x); //default constructor 

                ConstructorAgain e2 = new ConstructorAgain("maharashtra");// paramaterize constructor 
          
        }
    }
}
