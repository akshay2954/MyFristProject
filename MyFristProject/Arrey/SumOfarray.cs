using System;
using System.Collections.Generic;
using System.Text;

namespace MyFristProject.Arrey
{
    class SumOfarray                  // sum of array  1
    {
        public int Summ (int []a ,int n )
        {
            
            int sum = 0;
            for(int i=0;i<a.Length;i++)
            {
                sum += a[i]; 
            }
            return sum;

        }
        static void Main(string[] args)
        {
            
            int[] ar = new int[1000];
          
            Console.WriteLine("Enter The Size of Array");
            int size = int.Parse(Console.ReadLine());
          
       
            Console.WriteLine("Enter the array element ");
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i<ar.Length; i++)
            {
                ar[i] = int.Parse(Console.ReadLine());
            }
            SumOfarray s = new SumOfarray();
        //    int sum =s.Summ(ar,n);
           // Console.WriteLine("Total = "+ sum);

        }    
    }
}
