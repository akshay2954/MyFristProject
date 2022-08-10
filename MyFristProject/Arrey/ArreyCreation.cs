using System;
using System.Collections.Generic;
using System.Text;

namespace MyFristProject.Arrey
{
    class ArreyCreation                      // array creation int type           
    {
        private static int i;

        static void Main(string[] args)
        {
            //  decler and assign at as same time 
            //  int[] ar = { 1, 2, 3, 4, };         //1 way to create  arrey
            // ar[4] = 55;

             
            // int[] a = new int[5];               // using second  Ne 
            /* a[0] = 54;                           basic creation 
             a[1] = 55;                           
             a[2] = 56;                             Hardcore value 
             a[3] = 57;
             a[4] = 58;*/

                                                       // 2 way 
            int[] a = new int[5];                       // syntax  
            Console.WriteLine("Enter array element ");  // from user value 
            for (int i = 0; i < a.Length; i++)        // for loop more then one value 
            {                                             // *
               // a[i] = int.Parse(Console.ReadLine());
            }

                                                               // 3 way  
            int[] myarray = new int[4] { 3, 5, 5, 6 };  // syntax with decalr 
            Console.WriteLine(".........Array Display............");


            for (int i = 0; i < a.Length; i++)                // 1 way to display
            {                                                 // *
                Console.Write(a[i]+" ");
            }

            Console.WriteLine("...................................");
            foreach(int x in a)                              // 2 way to Display 
            {                                                // foreach Loop 
                Console.WriteLine(x);                        // *   display only variable name 
            }


            Console.WriteLine(".................................");
            Console.WriteLine(string.Join(" ",a));          // 3 way traditional 
                                                            // * 
            

        


        }
    }
}
