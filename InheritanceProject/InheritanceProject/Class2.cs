using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceProject
// https://youtu.be/F0OqWKayYpo?list=PLVlQHNRLflP-jc5Fbhfdhzv52AWYq836j
{
    class Class2 : Class1
    {
        Class2() // not have to be public, because implicit is private, the execution is from class2, doesnt have problem to acces the class2
        {
            Console.WriteLine("Class2 constructor is call");
        }

        public void Test3()
        {
            Console.WriteLine("Method 3");

        }



        static void Main()
        {
            Class2 c = new Class2(); // Constructor child class2
            c.Test1();
            c.Test2();
            c.Test3();
            Console.ReadLine();

            //Class1 p = new Class1();
            //// p.Test3(); // can't access to child class.
            //p.Test1();
            //p.Test2();
            //Console.ReadLine();


            Class1 p; // P is a variabe of class1
            Class2 c2 = new Class2(); // c is instance of class2
            p = c2; // P is a referece of parent class created by using class instance
            p.Test1();
            p.Test2();
            // p.test3(); // cant call the child class. 
            Console.ReadLine();

        }

    }
}
