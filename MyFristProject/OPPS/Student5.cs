using System;
using System.Collections.Generic;
using System.Text;

namespace MyFristProject.OPPS
{
    class Student5
    {
        string id;
         int che, phy, math, bio, eng, total ,avr;
        string name;
        double Percentage;


        public void AcceptDetails(string id, string name, int che, int phy, int math, int bio, int eng)
        {
            this.name = name;
            this.id = id;
           
            this.che = che;
            this.phy = phy;
            this.math = math;
            this.bio = bio;
            this.eng = eng;
    



     
           
        }



        public void Logic()
        {
            total = che + phy + math + bio + eng;
            avr = total / 5;
            Percentage = (total / 500.0) * 100;

            if (this.Percentage > 90)
            {
                Console.WriteLine("A Gread");
            }
            else if (this.Percentage >= 80 && this.Percentage <= 90)
            {
                Console.WriteLine(" B Gread");
            }
            else if (this.Percentage >= 60 && this.Percentage < 80)
            {
                Console.WriteLine(" C Gread");
            }
            else if (this.Percentage >= 35 && this.Percentage < 60)
            {
                Console.WriteLine("D Gread");
            }
            else

                Console.WriteLine(" Fail ");


        }

        public void Display()
        {

            Console.WriteLine("Physic="+phy);
            Console.WriteLine("chemistry=" + che);
            Console.WriteLine("Math=" +math);
            Console.WriteLine("Biology=" +bio);
            Console.WriteLine("English=" +eng);
            Console.WriteLine("-----------------");
            Console.WriteLine("Percentage= "+Percentage);
            
            
        }
         


        static void Main(string[] args)
        {
            Student5 e = new  Student5();
            e.AcceptDetails("H0100", "Akshay", 98,75,63,90,57);
           
            e.Logic();
            e.Display();


        }

    }
}