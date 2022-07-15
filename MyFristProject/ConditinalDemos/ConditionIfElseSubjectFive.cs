using System;
using System.Collections.Generic;
using System.Text;

namespace MyFristProject.ConditinalDemos
{
    class ConditionIfElseSubjectFive
    {
        //using condition if else calculate the total of 5 subject and check percentage using if else
        static void Main(string[] args)
        {
            double chemistry, physic, maths, biology, english, total, per,avr;
            Console.WriteLine("Calculate The total, percentage and division to the mark of 5 subjects:\n");
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine("\n\n");
            Console.WriteLine("Enter The Mark Of Physic");
            physic = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the mark of chemistry");
            chemistry = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter The mark of maths");
            maths = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the mark of biology");
            biology = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter The mark of english");
            english = Convert.ToInt32(Console.ReadLine());

            total = chemistry + physic + maths + biology + english;
            avr = total / 5.0;
            per = (total / 500) * 100;
            Console.WriteLine("total Marks:"+ total);
            Console.WriteLine("percentage:" + per);
            if(per > 70)
            {
                Console.WriteLine("Distinction Class");
            }
            else if( per>60 && per<=70)
            {
                Console.WriteLine("Frist Class");
            }
            else if( per>50 && per<=60)
            {
                Console.WriteLine("Second Class");
            }
            else if( per>=35 && per<=50)
            {
                Console.WriteLine("Pass Class");
            }
            else
            {
                Console.WriteLine("Fail");
            }
            
        }
    }
}
