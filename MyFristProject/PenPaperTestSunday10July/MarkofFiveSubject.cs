using System;
using System.Collections.Generic;
using System.Text;

namespace MyFristProject.PenPaperTest
{
    class MarkofFiveSubject
    {
        // wright a program print student mark, average and percentage 
        static void Main(string[] args)
        {
            double che, phy, math, bio, eng, total, avr, per;
            Console.WriteLine("Enter a chemistry mark");
            che = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a Physic mark");
            phy = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a Math mark");
            math = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a Biology mark");
            bio = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a English mark");
            eng = int.Parse(Console.ReadLine());
            total = che + phy + math + bio + eng;
            avr = total / 5.0;
            per = (total / 500) *100;
            Console.WriteLine("Total Mark of Subject ="+total);
            Console.WriteLine("Total Average of Subject ="+ avr); 
            Console.WriteLine("total Percentage ="+ per);


        }
    }
}
