using System;
using System.Collections.Generic;
using System.Text;


namespace ConsoleApp02MrRaju
{
    class ParametrizedConstructorDemo
    {
        int x; // default value x = 0 
        public ParametrizedConstructorDemo(int i)
        {
            x = i;
            Console.WriteLine("Parameterized Constructor is called: " + i);
        }

        public void Display()
        {

            Console.WriteLine("value of x is " + x);
        }


        static void Main()
        {
            ConsoleApp02MrRaju.ParametrizedConstructorDemo cd1 = new ConsoleApp02MrRaju.ParametrizedConstructorDemo(10);
            ConsoleApp02MrRaju.ParametrizedConstructorDemo cd2 = new ConsoleApp02MrRaju.ParametrizedConstructorDemo(20);
            // we can pass parameters 

            // two instances are create, different place of memory
// 2.Parametrized constructor

//If a constructor method is defined with out any parameters we call
//that as parameterized constructor and these consturctors can be
//defined by the programmers only but never can be defined implicitly.


            cd1.Display();
            cd2.Display();
            Console.ReadLine();
        }
    }
}