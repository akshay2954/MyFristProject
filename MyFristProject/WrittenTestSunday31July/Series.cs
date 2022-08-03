using System;
using System.Collections.Generic;
using System.Text;

namespace MyFristProject.WrittenTestSunday31July
{
    class Series
    {
       // 5. print Series
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number ");
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i <=num; i++)
            {
                int a = i * i - 1;
                Console.WriteLine(a+" ");
            }

        }
    }
}
