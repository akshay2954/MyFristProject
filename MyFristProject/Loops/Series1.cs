using System;
using System.Collections.Generic;
using System.Text;

namespace MyFristProject.Loops
{
    class Series1
    {
        // Print Number series in different types using ( Nested for loop)
        static void Main(string[] args) 
        {
            // Print Number Series 
            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 != 0)
                {
                   // Console.WriteLine(i);=    1,4,3,16,5,36....
                   //Console.WriteLine(i*i);//= 1,8,9,64,25....
                   Console.WriteLine(-i);//=    -1,4,-3,16,-5,36...
                }
                else if (i%2==0)
                {
                    //Console.WriteLine(i*i);=    1,4,3,16,5,36...
                    //Console.WriteLine(i*i*i);=  1,8,9,64,25....
                    Console.WriteLine(i*i);//=    -1,4,-3,16,-5,36...
                }


            }


           
        }
    }
}
