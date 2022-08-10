using System;
using System.Collections.Generic;
using System.Text;

namespace MyFristProject.Arrey
{
    
    class SumofEvenArray
    {
        public int Evesum(int[]a )
        {
            int sum = 0;
            for(int i=0;i<a.Length;i++)
            {
                if (a[i]%2==0)
                {
                    sum = sum + a[i];
                }
            }
            return sum;
        }
        static void Main(string[] args)
        {
            int[] ar = new int [5];              // array object 
            Console.WriteLine(" Enter a array element ");
            for(int i=0; i<ar.Length;i++)
            {
                ar[i] = int.Parse(Console.ReadLine());
               
            }
            SumofEvenArray s = new SumofEvenArray();
            int sum=  s.Evesum(ar);
            Console.WriteLine("Even number sum="+ sum);
        }
    }
}
