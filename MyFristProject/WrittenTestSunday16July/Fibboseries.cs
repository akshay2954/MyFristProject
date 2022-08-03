using System;
using System.Collections.Generic;
using System.Text;

namespace MyFristProject.WrittenTestSunday16July
{
    class Fibboseries

    {
        static void Main(string[] args)
        {

			int i = 1;
			while (i <= 5)
			{
				int j = 1;
				while (j <= 5)
				{
					if (j == 2)
					{
						break;
						Console.WriteLine(j);
					}
					j++;
				}
				
				Console.WriteLine(i);
			}





		}











	}
}   
      
     