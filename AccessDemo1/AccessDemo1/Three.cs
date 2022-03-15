using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessDemo1
{

    //Case 3: consuming members of a class form non-child class of same project
    class Three
    {
        
        static void Main() { 
        // create the instance
        Program p = new Program();
            p.Test2();
            p.Test4();
            p.Test5();

            // we can use in the class : private, protected, protected internal
            Console.WriteLine("Case 3: consuming members of a class form non-child class of same project");
            Console.ReadLine();
        }
    }
}
