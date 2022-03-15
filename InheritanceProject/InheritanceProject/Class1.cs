using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceProject
{
    class Class1
    {
        public Class1() // have to be public, because implicit is private, you have to especify
        {
            Console.WriteLine("Class1 constructor is call");
        }

        public void Test1()
        {
            Console.WriteLine("Method 1");
        }

        public void Test2()
        {
            Console.WriteLine("Method 2");
        }
    }
}
