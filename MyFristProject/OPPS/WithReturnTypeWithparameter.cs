 using System;
using System.Collections.Generic;
using System.Text;

namespace MyFristProject.OPPS
{
    class WithReturnTypeWithparameter
    {
        // with return with parameter 
        public float AreaOfCircle(int redius)
        {
            float  PI = 3.14f; ;
            return ( PI * redius * redius);

        }
        static void Main(string [] args)
        {
            WithReturnTypeWithparameter e= new WithReturnTypeWithparameter();
            float circle = e.AreaOfCircle(8);// return with calling circle method e
            Console.WriteLine("Area Of Circle = "+ circle);
        }
    }
}
