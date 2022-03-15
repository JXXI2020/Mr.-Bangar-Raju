using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessDemo2
{

    //Case 5: Consuming members of a class from child class on a different project
    class Four : AccessDemo1.Program
    {
        static void Main(string[] args)
        {
            Four f = new Four();
            f.Test3();
            f.Test4();
            f.Test5();
            Console.WriteLine("Case 5: Consuming members of a class from child class on a different project");
            Console.ReadLine();
        }
    }
}
