using System;
using System.Collections.Generic;
using System.Text;

namespace MyFristProject.New_OPPS
{
    class OnotherClass: AccessPrivateModifiers // parent child relation
    {
        static void Main(string[] args)
        {
            AccessPrivateModifiers p = new AccessPrivateModifiers(); // internal modifiers object .
            Console.WriteLine(p.name);
            p.showname();

            OnotherClass o = new OnotherClass();  // protected modifiers object. 
            Console.WriteLine(o.per);
            o.show_per();

            OnotherClass k = new OnotherClass(); // public modifiers object.
            Console.WriteLine(k.sir_name);
            k.showsir();
        }
    }
}
