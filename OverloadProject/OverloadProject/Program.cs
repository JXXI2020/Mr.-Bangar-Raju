using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadProject
{
    class Program
    {
        public void Test()
        {
            Console.WriteLine("1st Method");
        }
        //public string Test() // Error ya esta definido, 
        //{
        //    Console.WriteLine("1st Method");
        //}




        public void Test(int i)  // sobrcarga
        {
            Console.WriteLine("2nd Method");
        }

        public void Test(string s)  // sobrcarga
        {
            Console.WriteLine("3st Method");
        }

        public void Test(int i, string s)  // sobrcarga
        {
            Console.WriteLine("4th Method");
        }

        public void Test(string s, int i)  // sobrcarga
        {
            Console.WriteLine("5th Method");
        }


        static void Main(string[] args)
        {
            Program p = new Program(); // Create the instance
            p.Test();
            p.Test(3);
            p.Test("String");
            p.Test(4, "erte");
            p.Test("fer", 5);
            Console.ReadLine();

        }
    }
}
