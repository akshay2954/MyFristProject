using System;
using System.Collections.Generic;
using System.Text;

namespace MyFristProject.ConditinalDemos
{
  class CheckVowelusingLogicalOP
    {    // Using Logical Operator( Eighter OR ||)
        // WAP to check the char is vowel or consonants using if esle condition either or operator 
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the char");
            char ch = Convert.ToChar(Console.ReadLine());
            if (ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U'||ch=='a'
                ||ch=='e'||ch=='i'||ch=='o'||ch=='u')
            {
                Console.WriteLine(" its a vowel");
            }
            else
            {
                Console.WriteLine("its Consonants ");
            }
            
            
        }
        

    }
}
