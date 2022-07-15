using System;
using System.Collections.Generic;
using System.Text;

namespace MyFristProject.PenPaperTestSunday10July
{
    class CheckAlphaVowelOrConsonantr
    {
        // Check Vowel or not 

        static void Main(string[] args)
        {
            Console.WriteLine("enter Alphabet");
            char ch = Convert.ToChar(Console.ReadLine());
            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' ||
                ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
            {
                Console.WriteLine(" Vowel");


            }
            else
            {
                Console.WriteLine("consonant");
            }

        }
    }
}
