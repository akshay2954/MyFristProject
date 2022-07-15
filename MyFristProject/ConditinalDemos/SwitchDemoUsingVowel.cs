using System;
using System.Collections.Generic;
using System.Text;

namespace MyFristProject.ConditinalDemos
{
    class SwitchDemoUsingVowel
    {
        static void Main(string[] args)
        {
            //Check Vowel or not using ( "Only Switch Case )
            char ch;
            Console.WriteLine("Enter A char");
            ch = Convert.ToChar(Console.ReadLine());
            switch (ch)
            {
                case 'a' : Console.WriteLine(" Vowel");
                    break;
                case 'A': Console.WriteLine("vowel");
                    break;
                case 'e':
                    Console.WriteLine(" Vowel");
                    break;
                case 'E':
                    Console.WriteLine("vowel");
                    break;
                case 'i':
                    Console.WriteLine(" Vowel");
                    break;
                case 'I':
                    Console.WriteLine("vowel");
                    break;
                case 'o':
                    Console.WriteLine(" Vowel");
                    break;
                case 'O':
                    Console.WriteLine("vowel");
                    break;
                case 'u':
                    Console.WriteLine(" Vowel");
                    break;
                case 'U':
                    Console.WriteLine("vowel");
                    break;
                default: Console.WriteLine(" consonent");
                    break;
                    Console.ReadKey();

            }

               
        }
    }
}
