using System;
using System.Collections.Generic;
using System.Text;

namespace MyFristProject.Inheritane_Demo
{
    class Flower
    {
        public virtual void show()
        {
            Console.WriteLine("Rose is a Flower ");
        }

    }
    class Rose : Flower  // can't inherit sealed class 
    {
        public sealed override void show()
        {
            Console.WriteLine(" Rose is a colorful");
        }
        
    }

  //  class RedRose: Rose                                    // multilevel Inhertance 

    class Sealedkeyworlduse1
    {
       static void Main(string[] args)
       {

        }
    }
}
