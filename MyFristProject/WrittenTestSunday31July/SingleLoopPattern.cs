using System;
using System.Collections.Generic;
using System.Text;

namespace MyFristProject.WrittenTestSunday31July
{
    class SingleLoopPattern
    {
        // 6. Pattern 
        static void Main(string[] args)
        {
            for (int i=1;i<=5;i++)
            {
                for(int j=1;j<=i;j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
            Console.WriteLine("----------------");
        }
    }
}
