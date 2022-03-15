using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp02MrRaju
{
    class CopyConstructor
    {
        int x;

        public CopyConstructor(int i) // parametrized Constructor
        {
            x = i;
        }

        // when we have a lot of parameters to pass we create:

        public CopyConstructor(CopyConstructor obj) // Copy constructor
        {
            x = obj.x; 
        }



        public void Display()
        {
            

            Console.WriteLine("Value of x is:" + x);
           
        }

        static void Main()
        {
            CopyConstructor cd1 = new CopyConstructor(10);
            cd1.Display();

            // create new instance
            CopyConstructor cd2 = new CopyConstructor(20);
            cd2.Display();

            // create new instance
            CopyConstructor cd3 = new CopyConstructor(cd1);
            cd2.Display();

            Console.ReadLine();
        }



    }
}
