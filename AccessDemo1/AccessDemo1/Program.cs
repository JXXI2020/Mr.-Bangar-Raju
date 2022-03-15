using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessDemo1
{

    // Case 1: Consuming members of a class from same class of same project
    public class Program
    {
        private void Test1()
        {
            Console.WriteLine("Private Method");
        }

        internal void Test2()
        {
            Console.WriteLine("internal Method");
        }

        protected void Test3()
        {
            Console.WriteLine("protected Method");
        }

        protected internal void Test4()
        {
            Console.WriteLine("protected internal Method");
        }

        public void Test5()
        {
            Console.WriteLine("public Method");
        }


        static void Main(string[] args)
        {
            Program p = new Program();
            p.Test1();
            p.Test2();
            p.Test3();
            p.Test4();
            p.Test5();
            Console.WriteLine("all this methods are call into the same class, all can be used");
            Console.WriteLine("Case 1: Consuming members of a class from same class");
            Console.ReadLine();

        }

         
    }
}
