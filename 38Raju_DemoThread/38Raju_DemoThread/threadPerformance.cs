using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace _38Raju_DemoThread
{
    class threadPerformance
    {
        public static void IncrementCounter1()
        {
            long Count = 0;
            for (long i = 0; i <= 10000000; i++)
                Count++;
            Console.WriteLine("IncrementCounter1: "+Count);
        }

        public static void IncrementCounter2()
        {
            long Count = 0;
            for (long i = 0; i <= 10000000; i++)
                Count++;
            Console.WriteLine("IncrementCounter2: " + Count);
        }

        static void Main()
        {

            // without threads
            Stopwatch s1 = new Stopwatch();
            s1.Start();
            IncrementCounter1();
            IncrementCounter2();
            s1.Stop();

            Console.WriteLine("Tiempo empleado contando in single threaded:"+ s1.ElapsedMilliseconds);
            //Console.ReadLine();

            // with threads
            Thread t1 = new Thread(IncrementCounter1);
            Thread t2 = new Thread(IncrementCounter2);
                       
            Stopwatch s2 = new Stopwatch();
            

            s2.Start();
            t1.Start();
            t2.Start();
            s2.Stop();

            t1.Join();
            t2.Join();
             
            Console.WriteLine("Tiempo empleado contando in multiple threaded:" + s2.ElapsedMilliseconds);
            Console.ReadLine();

        }

    }
}
