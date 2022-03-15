using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// https://youtu.be/9UB-G4AjxpU?list=PLVlQHNRLflP-jc5Fbhfdhzv52AWYq836j
namespace OverloadProject
{
    class LoadParent
    {
        public void Show()
        {
            Console.WriteLine("Parent's Show method is Called.");
        }
  
        public virtual void Test() // This method is override
        {
            Console.WriteLine("Parent's Test method is Called.");
        }
    }

    class LoadChild : LoadParent
    {
        // Overloading  "Show"  method parent's into the child class
        public void Show(int i)
        {
            Console.WriteLine("Child Show method is Called.");
        }

        // Overriding method Test
        public override void Test()
        {
            Console.WriteLine("Child's Test method is Called.");
        }

        static void Main()
        {
            LoadChild c = new LoadChild();
            c.Show();
            c.Test();
            c.Show(1);

            Console.ReadLine();
        }
    }


}
