using System;
using System.Collections.Generic;
using System.Text;

namespace MyFristProject.Loops
{
    class PrintPattern
    {
        // Print Pattern in Different types using ( Nested for loop)
        static void Main(string[] args)
        {
            for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <= 3; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine("===================");
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine("=================");

            for (int i = 1; i <= 5; i++)
            {
                for (int j = 5; j >= i; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine("================");

            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; ++j)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
            Console.WriteLine("================");

            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; ++j)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
            Console.WriteLine("======================");

            for (int i = 1; i <= 4; i++)
            {
                for (int k = 4; k >= i; k--)


                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("=====================");

            for (int i=4;i>=1;i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();

            }
            Console.WriteLine("======================");

            for (int i=4;i>=1;i--)
            {
                for(int j=i;j>=1;j--)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
            Console.WriteLine("=======================");

            //Pattern using Alphabet 
            for ( char i='A';i<='D';i++)
            {

                for(char j='A';j<=i;j++)
                {
                    Console.Write(j );
                }
                Console.WriteLine();

            }
            Console.WriteLine("===========================");

            for (char i = 'A'; i<= 'E';i++)
            {
                for(char j='A';j<=i;j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
            Console.WriteLine("=================");

            for(char i='D';i>='A';i--)
            {
                for (char j='A'; j<=i;j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
                    
            }
            Console.WriteLine("=================");

            for (int i=1; i<=4;i++)
            {
                if(i%2!=0)
                {
                    int c = 1;
                    for(char j='A';c<=i;j++)
                    {
                        Console.Write(j);
                            c++;
                    }

                    
                }
                else
                {
                    for (int j = 1; j<= i;j++)
                    {
                        Console.Write(j);
                    }
                }
                Console.WriteLine();
            }
           
            
       
        }
    }
}
