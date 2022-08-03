using System;
using System.Collections.Generic;
using System.Text;

namespace MyFristProject.New_OPPS
{
    class AccessPrivateModifiers // private modifiers access only class we can't access onother class.
    {

        private int roll_number = 10;        // Private 
        internal string name = "Akshay";     // Internal 
        protected double per = 73.60;        //  protected  
        public string sir_name = "Thakare";

        void showroll()  // private 
        {
            Console.WriteLine(" My roll Number = "+roll_number );
        }

        internal void showname() // Internal 
        {
            Console.WriteLine(" My name is =" + name );  
        }

        protected void show_per() //  protected 
        {
            Console.WriteLine("My percentage is "+ per);
        }

        public void showsir() // public
        {
            Console.WriteLine("my sir name is= "+sir_name);
        }
        

        static void Main(string[] args)
        {
            AccessPrivateModifiers a = new AccessPrivateModifiers(); //object 
            Console.WriteLine(a.roll_number); // private 
            a.showroll(); 

            Console.WriteLine(a.name);        // internal 
            a.showname();

            Console.WriteLine(a.per);        // protected 
            a.show_per(); 

            Console.WriteLine(a.sir_name);  //  public
            a.showsir();


        }


    }
   
}
