using System;
using System.Collections.Generic;
using System.Text;

namespace MyFristProject.Encapsulation
{
    class Bank
    {
        int account_number;
        string holder_name;
        int balance;
        public int Account_Number
        { 
             get
             {
                return  account_number;
             }
            set
            {
                account_number = value;
            }
        }
        public string  Holder_Name
        {
            get
            {
                return holder_name;
            }
            set
            {
                holder_name = value;
            }
        }
        public int Balance
        {
            get
            {
                return balance;
            }
            set
            {
                balance = value;
            }
        }


    }

    class Accountinfo
    { 
        static void Main(string[] args)
        {  
           Bank b = new Bank();
            b.Account_Number = 1229;
            b. Holder_Name = "Akshay Thakare ";
            b.Balance = 100000;

            Console.WriteLine("Account Number= "+b.Account_Number+ " Holder Name= " +b.Holder_Name+ "vBalance="+b.Balance);
               

        }
    }
}
