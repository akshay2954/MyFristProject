using System;
using System.Collections.Generic;
using System.Text;

namespace MyFristProject.PenPaperTestSunday10July
{
    class CheckAphaDigitorSpecialsymbolt
    {
        // Calculate  mark, average, percentage of five subject
        static void Main(string[] args)
        {
            Console.WriteLine("enter a char ");
            char a =Console.ReadLine()[0];
            if (a >= 'A' && a <= 'z')
            {
                Console.WriteLine("this is alphabet");
            }
            else if (a >='a'&&a<='z')
            {
                Console.WriteLine("this is also alphabet");
            }
            else if (a>='0'&& a <='9')
            {
                Console.WriteLine("this is digit");

            }
            else
            {
                Console.WriteLine("spicel symbol");
            }

        }
    }
}
