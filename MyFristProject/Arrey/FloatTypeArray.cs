using System;
using System.Collections.Generic;
using System.Text;

namespace MyFristProject.Arrey
{
    class FloatTypeArray
    {                                               // array creation float type 
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter A Array element size");
            int size = int.Parse(Console.ReadLine());
            float[] floatarray = new float[ size];
            Console.WriteLine("Enter a array element");
            for(int i=0;i<floatarray.Length;i++)
            {
            
   
            }

            //float[] floatarray = { 3.5, 2.5, 5.6 };
            Console.WriteLine("..............................");

            foreach(float  a in floatarray)
            {
                Console.WriteLine(a);
               
            }

                
            

            

                


        }
    }
}
