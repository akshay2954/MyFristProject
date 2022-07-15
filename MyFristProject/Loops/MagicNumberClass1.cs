using System;
using System.Collections.Generic;
using System.Text;

namespace MyFristProject.Loops
{
    class MagicNumberClass1
    {
        // Writw a program to print magic number Using ( While Loop Inner if Else)
        static void Main(string[] args)
        {
            int magicnumber = 50;
            while (true) 
            {
                Console.WriteLine("enter number");
                int num = int.Parse(Console.ReadLine());
                if(num>magicnumber)
                {
                    Console.WriteLine("you enter a greater number than magic number");
                    continue;
                }
                else if (num<magicnumber)
                {
                    Console.WriteLine("you enter a less number then magic number");
                }
                else
                {
                    Console.WriteLine("you enter a correct number");
                    break;
                }


            }

        }
    }
}
