using System;
using System.Collections.Generic;
using System.Text;

namespace MyFristProject.Loops
{
    class Series
    {
        // Write a program number series 1 to 10 using ( for loop)
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++) 
            {
                Console.WriteLine(i * i + 1 + " ");
            }

        }
    }
}
