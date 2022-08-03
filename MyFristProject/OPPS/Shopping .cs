using System;
using System.Collections.Generic;
using System.Text;

namespace MyFristProject.OPPS
{
    class Shopping
    {
        string purchase_item;
        int quantity;
        int price;
        int total_Bill;

        public void AcceptDetails(string purchase_item, int quantity, int price)
        {
            this.purchase_item = purchase_item;
            this.quantity = quantity;
            this.price = price;

            if (this.quantity <= 0)
            {
                Console.WriteLine("Please buy product ");
            }
            else
            {
               total_Bill = this.GetBill();

            }

        }

        public int GetBill()
        {
            return quantity * price;
        }



        public void Display()
        {
            Console.WriteLine("purchase Item=" + purchase_item);
            Console.WriteLine("Quentity =" + quantity);
            Console.WriteLine("Price =" + price);
            Console.WriteLine("total Bill="+ total_Bill);

            Console.WriteLine(".....Thank You.......");
        }





        static void Main(string[] args)
        {
            Shopping e = new Shopping();
            e.AcceptDetails("shirt", 5, 760);
            e.Display();



        }
    }
}
