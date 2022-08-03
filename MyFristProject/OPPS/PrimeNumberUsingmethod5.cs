using System;
using System.Collections.Generic;
using System.Text;

namespace MyFristProject.OPPS
{
    class PrimeNumberUsingmethod5
    {

        // print prime number using method .

        public void Show()
        {
            bool isPrime = true;
            Console.WriteLine("Prime Numbers : ");
            for (int i = 2; i <= 20; i++)
            {
                for (int j = 2; j <= 20; j++)
                {
                    if (i!= j && i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    Console.Write("\t" + i);
                }
                isPrime = true;
                
            }
        }
        static void Main(string[] args)
        {

            PrimeNumberUsingmethod5 e = new PrimeNumberUsingmethod5();
            e.Show();
        }
    }
}
