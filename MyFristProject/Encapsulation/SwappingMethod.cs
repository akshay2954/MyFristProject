using System;
using System.Collections.Generic;
using System.Text;

namespace MyFristProject.Encapsulation
{
    class SwappingMethod
    {
        public void swap(ref int a,ref  int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }


        static void Main(string[] args)
        {
            SwappingMethod s = new SwappingMethod();
            Console.WriteLine("Enter Frist Number");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second Number ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine(a+" "+b);
            Console.WriteLine("-------------");
            s.swap(ref a , ref  b);        // passby referance                  // Passby value
            Console.WriteLine(a+" "+b);
            
        }
    }
}
