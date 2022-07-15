using System;
using System.Collections.Generic;
using System.Text;

namespace MyFristProject.Loops
{
    class AdditionEvenNumber1to20
    {
       // addition of even number between 1 to 20....( For loop_)
        static void Main(string[] args)
        {
            int sum = 0;
            for(int i=1;i<=20;i++)
            {
                if(i%2==0)
                {
                    sum = sum + i;
                    
                    Console.WriteLine(sum);

                }
                
            }

            Console.WriteLine("Addition of Even Number between 1to10\nTotal = "+ sum);
        }
    }
}
