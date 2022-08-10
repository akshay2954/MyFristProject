using System;
using System.Collections.Generic;
using System.Text;

namespace MyFristProject.Inheritane_Demo
{
    class Testsumeven
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number ");
            int num = int.Parse(Console.ReadLine());                                       

        
            for (int  i =0;i<=num;i++)
            {
                 i = Convert.ToInt32(Console.ReadLine());
                int numbervalue = i;
                int currentNumber = int.Parse(Console.ReadLine());
                if (i == 0)
                {
                    break;
                }
                else
                {
                    if (currentNumber == i)
                    {
                        continue;
                    }        
                }
                Console.ReadKey();

            }
            

        }

    }
}
