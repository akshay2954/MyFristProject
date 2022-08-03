using System;
using System.Collections.Generic;
using System.Text;

namespace MyFristProject.SpecialPattern
{
    class Pattern1
    {
        static void Main(string[] args)
        {
            for( int i=1; i<=4; i++)
            {
                for ( int j= 1; j<=i; j++)
                {
                    if( j==2 || j==4)
                    {
                        Console.Write("0");
                 
                    }
                    else
                    {
                        Console.Write("1");
                    }

                }
                Console.WriteLine();
              

            }
            Console.WriteLine("--------------");
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    if (i == 3 || j == 3)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("=================");
            for (int i= 4; i>=1;i-- )
            {
                for (int j=1;j<=i;j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
            Console.WriteLine("---------------");
          
            for (char i='D'; i>='A'; i--)
            {
                for ( char j= 'A'; j<=i;j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
            Console.WriteLine("===================");


            for (int i=1; i<=4; i++)
            {
                for (int j=1; j<=4; j++ )
                {
                    if(j==1 || j==4 || j==i)
                    {
                        Console.Write("* ",j);
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                    
                }
                Console.WriteLine();
            }
            Console.WriteLine("-----------------");
         
        }
    }
}
