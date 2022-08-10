using System;
using System.Collections.Generic;
using System.Text;

namespace MyFristProject.Arrey
{
    class OddElementCount
    {
                                                // even odd Count  2
        static void Main(string[] args)
        {
            int[] arr = new int[100];
            int i, num, evennum, oddnum;

            
            Console.WriteLine("Enter size of the array: ");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter " + num + " elements in the array: ");

            for (i = 0; i < num; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            evennum = 0; 
            oddnum = 0; 

            for (i = 0; i < num; i++)
            {
                
                if (arr[i] % 2 == 0)
                {
                    evennum++;
                }
                else
                {
                    oddnum++; 
                }
            }

            Console.WriteLine("Total even  numbers: " + evennum);
            Console.WriteLine("Total odd numbers: " + oddnum);


            Console.ReadLine();
        }
    }  
           
}
