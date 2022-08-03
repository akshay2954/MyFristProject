using System;
using System.Collections.Generic;
using System.Text;

namespace MyFristProject.Encapsulation
{
    class PrimeMethodsum
    {
        int Sumprime(int n)
        {
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                int num = i;
                bool isprime = true;

                for (int j = 2; j < num; j++)
                {
                    if (num % j == 0)
                    {
                        isprime = false;
                        break;
                    }
                }
                if (isprime == true)
                {
                    sum = sum + i;
                }

            }
            return sum;

        }    

          
        static void Main(string[] args)
        {
            PrimeMethodsum p = new PrimeMethodsum();
            int ans = p.Sumprime(10);
            Console.WriteLine(ans);
            Console.WriteLine("-----------------------");
        }
    }
}
