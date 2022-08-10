using System;
using System.Collections.Generic;
using System.Text;

namespace MyFristProject.Arrey
{                                                 // array cretion char type 
    class CharArrayDemo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of array") ;
            int size = int.Parse(Console.ReadLine());
            char[] ch = new char[size];                             // from user
            Console.WriteLine("Enter the char element ");
            for(int i=0;i<ch.Length;i++)                           // for enter 
            {
                ch[i] = Convert.ToChar(Console.ReadLine());
            }
            Console.WriteLine(".......................");

         // char[]= ch { 'd','f','#','e','a'};                     // Hard Core Value 


            foreach(char c in ch)                                   // foreach Diaplay
            { 
                Console.WriteLine(c);                            // Display pourpose 
            }
        }
    }
}
