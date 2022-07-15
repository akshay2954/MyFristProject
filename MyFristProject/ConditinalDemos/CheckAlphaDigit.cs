using System;
using System.Collections.Generic;
using System.Text;

namespace MyFristProject.ConditinalDemos
{
    class CheckAlphaDigit
    {
        // WAP To Check the letter of intnt number is digit or alphabet using if else condition
        // Using ( And && Operator )
        static void Main(string[] args)
        {
            
             Console.WriteLine("Enter char");
            //  char ch = Convert.ToChar(Console.ReadLine());
            char ch = Console.ReadLine()[0];

             if(ch >= 'A' && ch<= 'Z')
            {
                Console.WriteLine(" This is Alphabet:");
            }
            else if(ch>= 'a' && ch<= 'z')
            {
                Console.WriteLine(" This is Alphabet:");
            }
            else if (ch>='0' && ch<= '9')
            {
                Console.WriteLine("This is Digit:");
            }
            else 
            {
                Console.WriteLine("Special symbol ");
            }
            
        }
    }
}
