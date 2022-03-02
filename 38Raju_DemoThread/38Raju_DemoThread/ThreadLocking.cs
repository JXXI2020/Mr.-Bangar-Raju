using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _38Raju_DemoThread
{
    internal class ThreadLocking
    {
        public void Display()
        {
            
            Console.WriteLine("[CSharp is an ");
            Thread.Sleep(1000);
            Console.WriteLine("Object Oriented Language]");
            
        }

        public void DisplayLock()
        {
            // locked mechanism: if you lock a method, 1 thread would be aloud to execute the code
            // only one thread are allowed and can execute the code
            lock (this)
            {
                Console.WriteLine("[CSharp is an ");
                Thread.Sleep(1000);
                Console.WriteLine("Object Oriented Language] lock");
            }
        }
        static void Main()
        {
            ThreadLocking obj = new ThreadLocking();
            // without threads
            Console.WriteLine("without threads ");

            obj.Display();
            obj.Display();
            obj.Display();
            // with threads
            Console.WriteLine("    ");
            Console.WriteLine("with threads, without lock  ");
            Thread thread1 = new Thread(obj.Display); // because method display is non static, we can access directly into another method non static: Main
            Thread thread2 = new Thread(obj.Display);
            Thread thread3 = new Thread(obj.Display);
            thread1.Start(); thread2.Start(); thread3.Start();

            // with threads, with locks
            Console.WriteLine("    ");
            Console.WriteLine("with threads, with lock  ");
            Thread thread4 = new Thread(obj.DisplayLock); 
            Thread thread5 = new Thread(obj.DisplayLock);
            Thread thread6 = new Thread(obj.DisplayLock);
            thread4.Start(); thread5.Start(); thread6.Start();



            Console.ReadLine();
        }
    }
}
