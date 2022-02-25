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
            Console.WriteLine("Test3 is exiting ");
        }

        static void Test4()
        {
            for (int i = 1; i <= 10; i++)
                Console.WriteLine("Test4; " + i);
            Console.WriteLine("Test4 is exiting ");
        }

        // Video Part 3
        // static void Test5(int max) // change int to obj
        static void Test5(object max)
        {
            int num = Convert.ToInt32(max);
            for (int i = 1; i <= num; i++)
                Console.WriteLine("Test5; " + i);
            Console.WriteLine("Test5 is exiting ");
        }
        // Video part 4: we use test 6,7,8
        static void Test6()
        {
            Console.WriteLine("Test6 is starting ");
            for (int i = 1; i <= 25; i++)
                Console.WriteLine("Test6; " + i);
            Thread.Sleep(5000);// 5 seconds this thread is not alive

            Console.WriteLine("Test6 is exiting ");
        }

        static void Test7()
        {
            Console.WriteLine("Test7 is starting ");
            for (int i = 1; i <= 25; i++)
                Console.WriteLine("Test6; " + i);
            Console.WriteLine("Test7 is exiting ");
        }

        static void Test8()
        {
            Console.WriteLine("Test8 is starting ");
            for (int i = 1; i <= 25; i++)
                Console.WriteLine("Test6; " + i);
            Console.WriteLine("Test8 is exiting ");
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

            // Part 3: 
            // Instantiation is a process of binding the method with a delegate
            //ThreadStart obj = new ThreadStart(Test4); // 1 way
            //ThreadStart obj = Test4; //2 way
            //ThreadStart obj = delegate () { Test4(); }; // 3 way
            ThreadStart obj = () => Test4(); // Anonymous methods lambda operation
            Thread t4 = new Thread(obj);
            // or (is the same):
            // Thread t = new Thread(Test4);           

            t4.Start();
            Console.ReadLine();

            // 
            //ThreadStart obj2 = () => Test5(); // We cant use this, have error
            ParameterizedThreadStart obj2 =new ParameterizedThreadStart(Test5); // the parameter TEst5, only can be an object, so (1)
            Thread t5 = new Thread(obj2);
            t5.Start(20); // here we pass the parameter to the thread
            Console.ReadLine();

            // Video part 4 
            Console.WriteLine("Thread main for video 4 is starting ");
            Console.ReadLine();
            Thread t6 = new Thread(Test6);
            Thread t7 = new Thread(Test7);
            Thread t8 = new Thread(Test8);
            t6.Start();            t7.Start();            t8.Start();
            // For make the main thread exit after the childs(obligate): use join
            t6.Join(3000); t7.Join(); t8.Join(); // 3000 make the main exit, dont wait for the child
            Console.WriteLine("Thread main is exiting ");// MAin thread exit, in the midle of the  time, this cant wait for the childs.
            // For make y¡the main thread exit after the childs: use join
            Console.ReadLine();
        }
    }
}
