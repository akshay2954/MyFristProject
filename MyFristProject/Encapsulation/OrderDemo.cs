using System;
using System.Collections.Generic;
using System.Text;

namespace MyFristProject.Encapsulation
{
    class OrderDemo
    {
        int order;
        string product_name;
        int price;
        int qyt;
        int total_bill;

        OrderDemo(int order,string product_name,int price,int qyt) // paramater 
        {
            this.order = order;                     // 1 use of this.
            this.product_name = product_name;
            this.price = price;
            this.qyt = qyt;
        }
        OrderDemo():this(3, "Laptop",73888,3)     // call parameter constructor use of this Key default Constructor
        { 
            total_bill = price * qyt;
            this.Display(); //  use 2 call display method
        }

        void Display()
        {
            Console.WriteLine("Order Details=" + order);
            Console.WriteLine("Producr Name="+ product_name);
            Console.WriteLine("Price="+price); ;
            Console.WriteLine("Quentity="+qyt);
            Console.WriteLine("---------------");
            Console.WriteLine("Total Bill="+total_bill);
          
        }

        static void Main(string[] args)
        {
            //OrderDemo o = new OrderDemo(2, "Laptop", 45000, 6);
            OrderDemo o2 = new OrderDemo(); // call default constructor 

        }
        
    }
}
