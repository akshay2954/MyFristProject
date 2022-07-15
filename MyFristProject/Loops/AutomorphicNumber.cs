using System;
using System.Collections.Generic;
using System.Text;

namespace MyFristProject.Loops
{
    class AutomorphicNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number ");
            int num = int.Parse(Console.ReadLine());
            if (CheckAutomorphicNumber(num))
            {
                Console.WriteLine(" AutomorphicNumber");
            }
            else
            {
                Console.WriteLine(" Not AutomorphicNumber");
            }
            Console.WriteLine();
        }

        public static bool CheckAutomorphicNumber(int num )
        {
            int square = num * num;
            while(num >0)
            {
                if (num%10!=square%10)
                {
                    return false;

                }
                num = num / 10;
                square = square / 10;
            }
            return true;
        }
    }
}
