using System;
using System.Collections.Generic;
using System.Text;

namespace MyFristProject.Arrey
{
    class CharReversArray
    {                                                      // char arry revers type hardcore value 
        static void Main(string[] args)
        {

             char[] b = { 'A', 'B', 'C', 'D', 'E' };
             Console.WriteLine(string.Join(" ",b));
             for (int i=b.Length-1;i>=0;i--)
             {
                 Console.Write(b[i] + " ");    
             }

            

        
        }
    }
}
