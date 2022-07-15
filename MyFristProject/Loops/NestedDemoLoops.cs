using System;
using System.Collections.Generic;
using System.Text;

namespace MyFristProject.Loops
{
    class NestedDemoLoops
    {
        // Nested Loop Demos  ( _loop Inner loop with if else_)
        static void Main(string[] args)
        {
           for (int i=1; i<=3; i++)
            {
                for( int j=1;j<=2;j++)
                {
                    Console.WriteLine( i);
                }
            }
        }
    }
}
