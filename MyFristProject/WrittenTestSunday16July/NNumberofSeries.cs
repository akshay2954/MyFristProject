using System;
using System.Collections.Generic;
using System.Text;

namespace MyFristProject.WrittenTestSunday16July
{
    class NNumberofSeries

    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the end number of series :\n");
            int num = int.Parse(Console.ReadLine());
            for(int i=1;i<-num;i++)
            {
                 int a = i * i + i * i * i;
                Console.WriteLine(a+" ");
            }
          

        }  
    }
}
