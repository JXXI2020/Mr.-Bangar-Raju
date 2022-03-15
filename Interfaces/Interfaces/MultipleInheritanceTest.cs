using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{

    interface Interface1
    {
        void Test();
        void Show();
    }

    interface Interface2
    {
        void Test();
        void Show();
    }

    
    class MultipleInheritanceTest : Interface1, Interface2
    {
        public void Test() // we need to implement,  just implement, we dont consume the method. 
        {
            Console.WriteLine("InterfaceS method implemnted in child Class.");
        }

        void Interface1.Show()
        {
            Console.WriteLine("Declared in Interface1 and implemented in class");

        }

        void Interface2.Show()
        {
            Console.WriteLine("Declared in Interface2 and implemented in class");

        }

        static void Main()
        {
            MultipleInheritanceTest obj = new MultipleInheritanceTest();
            obj.Test();  // ambiguity appears when you are consuming, no implementing. 
            //obj.Show(); // error: no muestra este metodo no se puede llamar, you should implment

            Interface1 i1 = obj; // i1 is a reference of interface1
            i1.Show();

            Interface1 i2 = obj; // i1 is a reference of interface2
            i2.Show();


            Console.ReadLine();
        }


    }
}
