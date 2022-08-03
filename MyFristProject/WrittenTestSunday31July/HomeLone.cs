using System;
using System.Collections.Generic;
using System.Text;

namespace MyFristProject.WrittenTestSunday31July
{
    class HomeLone
    {
        float a, b;
        int c = 50000;
        int num = 4;


        void  Calculate (float d)
        {
            a= c*num*d / 100;
            Console.WriteLine(a);
        }
        void Calculate ( float d, float d2 )
        {
            {
                b = (c * d * 1 / 100) + (c * d2 * (num - 1) / 100);
                Console.WriteLine(b);
            }
        }
        static void Main(string[] args)
        {
            HomeLone h = new HomeLone();
            h.Calculate(5);

            h.Calculate(5, 10);

        }
    }
}
