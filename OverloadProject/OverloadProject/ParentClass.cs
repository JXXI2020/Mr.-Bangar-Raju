using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadProject
{
    class ParentClass
    {
        public virtual void Test1()
        {
            Console.WriteLine("Method Test1 from parent class.");
        }

        public void Test2()
        {
            Console.WriteLine("Method Test2 from parent class.");
        }

    }

    class ChildClass : ParentClass
    {

        //reimplenting using Method: overriding 
        public override void Test1()  
        {
            Console.WriteLine("Method Test1 from child class.");
        }
        //reimplenting using Method: Hiding/shadowing  
        public new void Test2() 
        {

            Console.WriteLine("Method Test2 from parent class.");
        }

        public void ParentTest1()
        {
            base.Test1();
        }

        public void ParentTest2()
        {
            base.Test2();
        }

        static void Main()
        {
            ParentClass p = new ParentClass();
            // 
            p.Test1();
            p.Test2();

            ChildClass c = new ChildClass(); // c is instance of child class
            // c is an instance of child class

            ParentClass pa = c;// pa is a reference of parent class created by using child's class
            pa.Test2();// invokes child classes method
            pa.Test1();// invokes parent classes method

            c.Test1();
            c.Test2();

            Console.ReadLine();
        }
    }
}
