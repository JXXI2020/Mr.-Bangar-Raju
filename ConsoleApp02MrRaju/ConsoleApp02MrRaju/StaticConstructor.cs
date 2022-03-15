using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp02MrRaju
{
    class StaticConstructor
    {

    static StaticConstructor()
        {
            Console.WriteLine("Static constructor is executed");
        }
    
    static void Main()
        {
            Console.WriteLine("Main method is executed");
        }

    }
}
