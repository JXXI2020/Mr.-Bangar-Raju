using System;

namespace TestProject_MrRaju
{
    class First
    {
        int x = 100;
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            // For use x var, you have to create a instance of your class 
            // for use it we have to instance
            First f = new First(); // f is a copy of the class
            // Or f is instance of class First. 

            First f_Variable; // f is variable of class
            // a copy of the class that is not initialized 
            f_Variable = new First();  // f is instance of class
            // a copy of the class that is initialized by using the new keyword

            // reference of a class

            Console.WriteLine(f.x+  " " + f_Variable.x);  // we can access using the instance

            f.x = 200;
            Console.WriteLine(f.x + " " + f_Variable.x);

            f_Variable.x = 300;
            Console.WriteLine(f.x + " " + f_Variable.x);
            //  you can create many instances of the class, and every instance have different memory allocation
            // security: each instance doesnt change another instance. 

            Console.ReadLine();

            // variable is a copy of a class, not initialized
            // Instance is a copy of a class, initialized by new keyword

            // ej reference Concept 

            First f1 = new First(); // f1 is instance of class
        
            First f2 = f1;  // f2 is reference of the class
            // variables cant use for calling the members
            // references can be use for calling the members. 
            // How can you difference the reference: reference is a 
            // copy of the class that is creating by using existence instance
            // reference is a pointer of a instance
            // reference can be used like instance
            Console.WriteLine(f1.x + " " + f2.x + "  >> both print 100, because is a reference of the class. F1 is the instance for wich is the memory allocated");

            f1.x = 200;
            Console.WriteLine(f1.x + " " + f1.x + "  >> both print 200, because f2 accessing the same memory of f1 ");

            f2.x = 300;
            Console.WriteLine(f1.x + " " + f1.x + "  >> both print 300, because they use the same memory space: the change in f2 is reflected in f1 ");



            Console.ReadLine();



        }
    }
}
