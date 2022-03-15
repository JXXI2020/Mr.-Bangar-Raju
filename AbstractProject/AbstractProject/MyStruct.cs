using System;

namespace AbstractProject
{

    //class MyStructur
    struct MyStructur
    {

        public void Display()
        {
            Console.WriteLine("Method in a class.");
        }

        static void Main()
        {
            MyStructur m1 = new MyStructur();
            m1.Display();
            Console.WriteLine();
        }
    }


}