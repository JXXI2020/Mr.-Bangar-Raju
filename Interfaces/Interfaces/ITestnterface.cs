using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    interface ITestnterface
    {
        //int x; // we can't declare any fields/variables under an interface. 
        void Add(int a, int b);

        void Sub(int a, int b);


    }


    interface ITestInterface2 : ITestnterface // If required an interface can inherit from another interface
    {
        void Sub2(int a, int b);


    }

    class ImplementationClass : ITestInterface2
    {
        public void Add(int a, int b) // have to have public
        {
            Console.WriteLine(a + b);
        }
        public void Sub (int a, int b)
        {
            Console.WriteLine(a - b);
        }
        public void Sub2(int a, int b) // have to have Sub2, too 
        {
            Console.WriteLine(- a + b);
        }
    

        static void Main(string[] args)
        {
            ImplementationClass obj = new ImplementationClass();
            obj.Add(100, 30);
            obj.Sub(100, 30);
            obj.Sub2(100, 30);

            //we can create references of the interface

            ITestInterface2 i = obj; // i is a reference of the interface create by using the child instance
            i.Add(100, 30); i.Sub(100, 30); i.Sub2(100, 30); 

        }

    }
}
