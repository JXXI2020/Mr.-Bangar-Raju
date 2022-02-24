using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _38Raju_DemoThread
{
    internal class Program
    {
        static void Test1()
        {
            for (int i= 1;i<=10;i++)
                Console.WriteLine("Test1; "+i);
            Console.WriteLine("Test1 is exiting " );
        }


        static void Test2()
        {
            for (int i = 1; i <= 10; i++)
            {
                if (i == 5)
                {
                    Console.WriteLine("Main thread going to sleep for 2 seconds");
                    Thread.Sleep(2000);// 5 seconds this thread is not function
                    Console.WriteLine("Main thread going to woke up");
                }
                    
                Console.WriteLine("Test2; " + i);
            }

        }

        static void Test3()
        {
            for (int i = 1; i <= 10; i++)
                Console.WriteLine("Test3; " + i);
            Console.WriteLine("Test1 is exiting ");
        }
        static void Main(string[] args)
        {
            // One thread
            Console.WriteLine("Hello thread, just one thread");
            Thread t = Thread.CurrentThread;
            t.Name = "Main thread";
            Console.WriteLine("Current executing thread is: "+ Thread.CurrentThread.Name);
            Console.ReadLine();

            // call de static methods
            Test1();
            
            Test2();
            
            Test3();
            Console.WriteLine("Current executing in one thread is end " );
            Console.ReadLine();
            
            // multi threading
            Console.WriteLine("Hello thread, with 3 threads");
            Console.ReadLine();
            Thread t1 = new Thread(Test1);
            Thread t2 = new Thread(Test2);
            Thread t3 = new Thread(Test3);
            t1.Start();
            t2.Start();
            
            t3.Start();
            Console.WriteLine("Thread main is exiting ");
            Console.WriteLine("Current executing in three threads is end ");       
            
            Console.ReadLine();
        }
    }
}
