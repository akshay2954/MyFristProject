using System;
using System.Collections.Generic;
using System.Text;

namespace MyFristProject.WrittenTestSunday24july
{
    class Fibbo
    {
		//4. WAP to print fibbo series upto 20 terms
		static void Main(string[] args)
		{
			int i;
			int n;
			int t1 = 0;
			int t2 = 1;
			int nextterm; 
            Console.Write("Display The Frist Term of Fibinaccy series : "  );
            Console.Write("---------------------------------------------");
            Console.Write("\n\n");
            Console.Write("Input the number of term to be display : ");

			n = int.Parse(Console.ReadLine());
			Console.Write("Here is the fibonacci series upto  to {0} terms : \n", n);
			Console.Write("{0}     {1} ", t1,t2);
			for (i = 3; i < n; i++)
			{
				nextterm = t1 + t2;
				Console.Write("{0} " ,nextterm);
				t1 = t2;
				t2 = nextterm;
            }
            Console.WriteLine("\n");
		}
    }
}
