using System;
using System.Collections.Generic;
using System.Text;

namespace MyFristProject.Arrey 
{ 
                                                        // hardcore value revers
    class ReversAreay   
    {
        static void Main(string[] args)
        {

            int[] a= { 55, 56, 57, 58, 50, 60 };
            Console.WriteLine(string.Join(" ",a));
            for (int i = a.Length-1; i >= 0; i--)    // a.length == to check the last position of array.
            {
                Console.Write(a[i]+" ");
            }

           
             
        }
    }
}
