using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessDemo2
{
    //Case 5 : consuming members of a class form non-child class of different project
    class Five
    {
        static void Main()
        {
            AccessDemo1.Program p = new AccessDemo1.Program();
            p.Test5();
            
            Console.WriteLine("Case 5 : consuming members of a class form non-child class of different project");
            Console.ReadLine();
        }

    }
}
