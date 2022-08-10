using System;
using System.Collections.Generic;
using System.Text;

namespace MyFristProject.Arrey
{


    class EvenPositionarray3     // check even position  3
    {
        static void Main(string[] args)
        {
                int[] ar = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
                Console.WriteLine("Elements of given array present on even position: ");

                for (int i = 0; i < ar.Length; i = i + 2)
                {
                    Console.Write(ar[i]);
                }

        }
    }
   
}