using System;
using System.Collections.Generic;
using System.Text;

namespace MyFristProject.Loops
{
    class BreakContinue
    {
        //  how to use break continue statement  ( for loop)
        static void Main(string[] args) 
        {
            
            {
                for (int i=1;i<=5;i++ )
                {
                    if (i == 6)
                    {
                        break;
                    }
                    Console.WriteLine(i);
                }
               
            }
            
        }
    }
}
