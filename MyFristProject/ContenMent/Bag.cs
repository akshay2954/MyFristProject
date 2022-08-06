using System;
using System.Collections.Generic;
using System.Text;

namespace MyFristProject.ContenMent
{
    class Pen  
    {
        string quality;
        string penname;
        string colour;
        string type;
        public string Quality  //property
        {
            get { return quality; }
            set { quality = value; }
        }

        public string PenName  // property
        {
            get { return penname; }
            set { penname = value; }
        }
        public string Colour  // property
        {
            get { return colour; }
            set { colour = value; }
        }
        public string  Type  // property
        {
            get { return type; }
            set { type = value; }
        }
    }
    class Bag
    {
        string brand_name;   // local variable 
        int price;
        string colour;
        Pen pe;
        public string Brand_Name  // prpperty
        {
            get { return brand_name; }
            set { brand_name = value; }
        }
        public int Price
        {
            get { return price; }
            set { price = value; }
        }

        public string Colour
        {
            get { return colour; }
            set { colour = value; }
        }
        public Pen Pe
        {
            get { return pe; }
            set { pe = value; }
        }

    }
    class Baginfo
    { 
         static void Main(string[] args)
        {
            Bag b = new Bag();           // Bag Class Object 
            b.Brand_Name = "SkyBag";     // set call bag property call
            b.Price = 1500;
            b.Colour = "SkyBlue";
              
            b.Pe = new Pen();               // Pen Class object 
            b.Pe.Quality = "Supper Quality";// set pen property call
            b.Pe.PenName = " Marker Pen";
            b.Pe.Colour = "Red ";
            b.Pe.Type = "Gel_Pen";

            Console.WriteLine("Bag Name= "+b.Brand_Name);   // get bag property call 
            Console.WriteLine("Bag Price= "+b.Price);
            Console.WriteLine("Bag Colour= " + b.Colour);
                Console.WriteLine("\n======================="  );

            Console.WriteLine("Pen Quality= "+ b.Pe.Quality);  // get bag property call 
            Console.WriteLine("Pen Name = "+b.Pe.PenName);
            Console.WriteLine("Pen Colour= "+ b.Pe.Colour);
            Console.WriteLine("Pen Type= "+ b.Pe.Type);

            
        }
    }
}
