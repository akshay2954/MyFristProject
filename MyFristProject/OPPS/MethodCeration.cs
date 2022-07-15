using System;
using System.Collections.Generic;
using System.Text;

namespace MyFristProject.OPPS
{
    class MethodCeration
    {
        //Syntax AssessModifier Returntype Methodname()
        //{
        //Logic
        //}
        //-> 1) No Return & No Parameter Type Method.
        public void show() // method defination or method body
        {
            Console.WriteLine("ShoW Method");
        }

        //-> 2) No Return type with Parameter.
        public void Addition(int a, float b)// <- Actual Parameter
        {
            float result = a + b;
            Console.WriteLine("Result =" + result);
        }

        //-> With Return Type No Parameter
        public int AreaRectangle()
        {
            int a = 5 * 4;
            return a;
        }

        //-> With Return With Parameter
        public float AreaofCircle(int r)
        {
            float PI = 3.14f;
            return (PI * r * r);

        }
    }
        class Demo
        {
            static void Main(string[] args)
            {
                MethodCeration e = new MethodCeration();// object creation
                e.show();// method calling

                e.Addition(5, 10.5f);//<- former Parameter

                int myArea = e.AreaRectangle();
                Console.WriteLine("Area Of Rectangle= " + myArea);

                float Circle= e.AreaofCircle(4);
                Console.WriteLine("Area Of Circle = "+ Circle);

            }
        }
    
}