using System;
using System.Collections.Generic;
using System.Text;

namespace MyFristProject.WrittenTestSunday31July
{
    class PrintPattern
    {
        // 4 print pattern
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = i; j >= 1; j--)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }

          Console.WriteLine("--------------------");
           for (int i=1; i<=5;i++)
            {
                for (int j=1;j<=i;j++)
                {
                    Console.Write(j%2);
                }
                Console.WriteLine();
            }
        }
    }
}
