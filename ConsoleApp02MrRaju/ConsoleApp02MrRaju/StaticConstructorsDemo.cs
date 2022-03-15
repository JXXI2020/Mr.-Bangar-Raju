using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp02MrRaju
{
    class StaticConstructorsDemo
    {
        int x; // these are defined by non-static constructors
        static int y; // these are defined by static constructors

        static StaticConstructorsDemo()  // Static because is explicitly declared
        {
            Console.WriteLine("Static constructor is call.");
        }

        public StaticConstructorsDemo(int x)  // this is not static constructor
        {
            this.x = x;
            Console.WriteLine("non-Static constructor is call.");
        }
        static void Main()
        {
            //Console.WriteLine("Main maethod is called.");
            //Console.ReadLine();


            //Console.WriteLine("Main maethod is called.");
            //StaticConstructorsDemo d1 = new StaticConstructorsDemo();
            //Console.ReadLine();


            //Console.WriteLine("Main maethod is called.");
            //StaticConstructorsDemo d1 = new StaticConstructorsDemo();
            //StaticConstructorsDemo d2 = new StaticConstructorsDemo();
            //Console.ReadLine();


            Console.WriteLine("Main method is called.");
            StaticConstructorsDemo d1 = new StaticConstructorsDemo(10);
            StaticConstructorsDemo d2 = new StaticConstructorsDemo(20);
             
            Console.WriteLine(y);
            //Console.WriteLine(x); Y only have one copy, is static, X have 2 diferent values , so you have to define, and call.
            Console.WriteLine(d1.x + " " + d2.x + " "); // x have separate value for each instance, x is not single.

            Console.ReadLine();

        }

    }
}
