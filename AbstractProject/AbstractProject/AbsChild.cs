using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractProject
{
    class AbsChild : AbsParent
    {
        // you need implement the method 
        public override void Mul(int x, int y)
        {
            Console.WriteLine(x * y);
        }

        public override void Div(int x, int y)
        {
            Console.WriteLine(x / y);
        } 

        static void Main()
        {
            AbsChild c = new AbsChild();
            // You cant create an intance of an abstract class
            // AbsParent p = new AbsParent(); >> Error
            
            // You can create a reference of an abstract class
            AbsParent p = c;

            c.Add(100, 10); c.Sub(100, 10);
            c.Mul(7, 8); c.Div(9, 3);

            p.Add(100, 10); p.Sub(100, 10);
            p.Mul(7, 8); p.Div(9, 3);
            
            Console.WriteLine();

        }
    }
}
